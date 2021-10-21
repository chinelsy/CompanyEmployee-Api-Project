using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeesApi.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ad48bb0-a861-437e-92dc-3b57f0541361", "31fa231a-8e8b-4547-a577-0f853b4ee0be", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee0835f1-c472-48db-b6e3-21cd73fa4144", "ae5129fc-9f0d-42b9-9e77-b1fc1fda3592", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ad48bb0-a861-437e-92dc-3b57f0541361");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee0835f1-c472-48db-b6e3-21cd73fa4144");
        }
    }
}
