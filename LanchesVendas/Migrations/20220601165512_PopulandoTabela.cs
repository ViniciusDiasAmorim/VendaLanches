using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesVendas.Migrations
{
    public partial class PopulandoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,CategoriaDescricao)" +
                "VALUES('Normal','Lanche feito com ingredientes comuns')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,CategoriaDescricao)" +
                "VALUES('Natural','Lanche feito com ingredientes naturais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,CategoriaDescricao)" +
                "VALUES('Especial','Lanche feito com ingredientes Especiais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,CategoriaDescricao)" +
                "VALUES('Vegano','Lanche feito com ingredientes veganos')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,CategoriaDescricao)" +
                "VALUES('Bebida','Bebidas dos mais variados tipos')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
