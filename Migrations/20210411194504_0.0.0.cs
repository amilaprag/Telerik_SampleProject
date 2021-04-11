using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Telerik_SampleProject.Migrations
{
    public partial class _000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
             name: "RegistrationMaster");

            migrationBuilder.CreateTable(
                name: "RegistrationMaster",
                columns: table => new
                {
                    Reg_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reg_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Reg_Age = table.Column<int>(type: "int", nullable: false),
                    Reg_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reg_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reg_CivilStatus = table.Column<bool>(type: "bit", nullable: false),
                    Reg_Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reg_Subscription = table.Column<bool>(type: "bit", nullable: false),
                    Reg_City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationMaster", x => x.Reg_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationMaster");
        }
    }
}
