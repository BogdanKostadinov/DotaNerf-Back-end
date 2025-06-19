using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotaNerf.Migrations
{
    /// <inheritdoc />
    public partial class PasswordHashing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440000"),
                column: "Password",
                value: "7Tf0uhxZnxOl1kLN7wzNNg==.CvoJhIIZ2cWEyiWy15Qw/CLHYZQZJE7KvKDW/Wrq7cM=");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("550e8400-e29b-41d4-a716-446655440000"),
                column: "Password",
                value: "admin");
        }
    }
}
