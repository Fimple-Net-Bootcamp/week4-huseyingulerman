using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace week4_huseyingulerman.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodPets_Foods_FoodId",
                table: "FoodPets");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodPets_Pets_PetId",
                table: "FoodPets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodPets",
                table: "FoodPets");

            migrationBuilder.RenameTable(
                name: "FoodPets",
                newName: "FoodsPets");

            migrationBuilder.RenameIndex(
                name: "IX_FoodPets_PetId",
                table: "FoodsPets",
                newName: "IX_FoodsPets_PetId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodPets_FoodId",
                table: "FoodsPets",
                newName: "IX_FoodsPets_FoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodsPets",
                table: "FoodsPets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodsPets_Foods_FoodId",
                table: "FoodsPets",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodsPets_Pets_PetId",
                table: "FoodsPets",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodsPets_Foods_FoodId",
                table: "FoodsPets");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodsPets_Pets_PetId",
                table: "FoodsPets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodsPets",
                table: "FoodsPets");

            migrationBuilder.RenameTable(
                name: "FoodsPets",
                newName: "FoodPets");

            migrationBuilder.RenameIndex(
                name: "IX_FoodsPets_PetId",
                table: "FoodPets",
                newName: "IX_FoodPets_PetId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodsPets_FoodId",
                table: "FoodPets",
                newName: "IX_FoodPets_FoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodPets",
                table: "FoodPets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodPets_Foods_FoodId",
                table: "FoodPets",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodPets_Pets_PetId",
                table: "FoodPets",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
