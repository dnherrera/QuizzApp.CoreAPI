﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApp.API.Migrations
{
    public partial class UserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "Questions",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(nullable: false)
            //             .Annotation("Sqlite:Autoincrement", true),
            //         QuestionContent = table.Column<string>(nullable: true),
            //         CorrectAnswer = table.Column<string>(nullable: true),
            //         Answer1 = table.Column<string>(nullable: true),
            //         Answer2 = table.Column<string>(nullable: true),
            //         Answer3 = table.Column<string>(nullable: true),
            //         QuizId = table.Column<int>(nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Questions", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Quizzes",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(nullable: false)
            //             .Annotation("Sqlite:Autoincrement", true),
            //         Title = table.Column<string>(nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Quizzes", x => x.Id);
            //     });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "Questions");

            // migrationBuilder.DropTable(
            //     name: "Quizzes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
