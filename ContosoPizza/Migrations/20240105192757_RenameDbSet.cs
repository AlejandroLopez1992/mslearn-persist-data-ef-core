using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoPizza.Migrations
{
    /// <inheritdoc />
    public partial class RenameDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_Toppinngs_ToppingsId",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toppinngs",
                table: "Toppinngs");

            migrationBuilder.RenameTable(
                name: "Toppinngs",
                newName: "Toppings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_Toppings_ToppingsId",
                table: "PizzaTopping",
                column: "ToppingsId",
                principalTable: "Toppings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_Toppings_ToppingsId",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings");

            migrationBuilder.RenameTable(
                name: "Toppings",
                newName: "Toppinngs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toppinngs",
                table: "Toppinngs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_Toppinngs_ToppingsId",
                table: "PizzaTopping",
                column: "ToppingsId",
                principalTable: "Toppinngs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
