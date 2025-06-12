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
    public UserController(
           IMapper mapper,
           IUserRepository userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
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
}

