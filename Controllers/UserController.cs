using AutoMapper;
using DotaNerf.DTOs;
using DotaNerf.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotaNerf.Controllers;

[ApiController]
[Route("/users")]
public class UserController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;
    private readonly IAuthenticationService _authenticationService;

    public UserController(
           IMapper mapper,
           IUserRepository userRepository,
           IAuthenticationService authenticationService)
    {
        _mapper = mapper;
        _userRepository = userRepository;
        _authenticationService = authenticationService;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsersAsync()
    {
        var users = await _userRepository.GetUsersAsync();

        if (!users.Any())
        {
            return NotFound("No users found in the database.");
        }

        var userDtos = users.Select(user => _mapper.Map<UserDTO>(user)).ToList();

        return Ok(userDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserAsync(Guid id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);

        if (user == null)
        {
            return NotFound();
        }

        var userDto = _mapper.Map<UserDTO>(user);
        return Ok(userDto);
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateUserAsync([FromBody] CreateUserDTO request)
    {
        var user = await _userRepository.CreateUserAsync(request);

        return Ok(_mapper.Map<UserDTO>(user));
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = await _authenticationService.AuthenticateAsync(request.Email, request.Password);

        if (user == null)
            return Unauthorized("Invalid credentials");

        var token = _authenticationService.GenerateJwtToken(user);

        var response = new LoginResponse
        {
            User = _mapper.Map<UserDTO>(user),
            Token = token,
            Expiration = DateTime.UtcNow.AddMinutes(60)
        };

        return Ok(response);
    }
}

