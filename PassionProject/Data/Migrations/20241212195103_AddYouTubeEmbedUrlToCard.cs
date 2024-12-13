﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PassionProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddYouTubeEmbedUrlToCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YoutubeEmbedUrl",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YoutubeEmbedUrl",
                table: "Cards");
        }
    }
}
