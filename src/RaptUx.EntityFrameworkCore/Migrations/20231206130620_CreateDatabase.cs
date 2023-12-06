using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaptUx.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChallengeUser_AbpChallenges_ChallengesId",
                table: "ChallengeUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TagUser_AbpTags_TagsId",
                table: "TagUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTags",
                table: "AbpTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpChallenges",
                table: "AbpChallenges");

            migrationBuilder.RenameTable(
                name: "AbpTags",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "AbpChallenges",
                newName: "Challenges");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Challenges",
                table: "Challenges",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChallengeUser_Challenges_ChallengesId",
                table: "ChallengeUser",
                column: "ChallengesId",
                principalTable: "Challenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagUser_Tags_TagsId",
                table: "TagUser",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChallengeUser_Challenges_ChallengesId",
                table: "ChallengeUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TagUser_Tags_TagsId",
                table: "TagUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Challenges",
                table: "Challenges");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "AbpTags");

            migrationBuilder.RenameTable(
                name: "Challenges",
                newName: "AbpChallenges");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTags",
                table: "AbpTags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpChallenges",
                table: "AbpChallenges",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChallengeUser_AbpChallenges_ChallengesId",
                table: "ChallengeUser",
                column: "ChallengesId",
                principalTable: "AbpChallenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagUser_AbpTags_TagsId",
                table: "TagUser",
                column: "TagsId",
                principalTable: "AbpTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
