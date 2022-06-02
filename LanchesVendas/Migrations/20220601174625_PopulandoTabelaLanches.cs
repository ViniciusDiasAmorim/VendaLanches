using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesVendas.Migrations
{
    public partial class PopulandoTabelaLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('Lanche Normal','8.99','Lanche feito de com ingredientes normais','01.jpg',0,1)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('X-Burguer','9.99','Mais pedido da casa muito delicioso e barato','04.jpg',0,1)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('Cheese-Burguer','9.99','Delicioso lanche com muito queijo','06.jpg',1,1)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('X-Salada','8.99','X-Salada padrao ouro da casa uma delicia!!!','14.jpg',0,1)");
          
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('Lanche Natural','7.99','Lanche feito com ingredientes naturais','08.jpg',1,2)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('X-burguer Natural','10.50','O mais pedido dos normais na forma natural','05.jpg',0,2)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('X Natural','8.99','Lanche saudavel, e com o molho X natural delicioso','02.jpg',0,2)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('X-Salada Natural','12.99','Salada já é natural, porem deixamos mais ainda','20.jpg',1,2)");
           
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('X-Tudo','28.99','Lanche com tudo e mais um pouco delicioso','15.jpg',1,3)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('Vegano-Tudo','32.99','Lanche VEGANO com tudo e mais um pouco delicioso','16.jpg',0,3)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('X-Naturalzão','25.99','Lanche natural super saudavel e delicioso','19.jpg',1,3)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('X-Normalzão','25.99','Lanche feito de com ingredientes normais e de forma super normal','10.jpg',1,3)");

            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('Lanche Vegano Normal','13.00','Feito com ingredientes vegano comuns','09.jpg',0,4)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('X-Burguer Vegano','15.99','Tem na versao natural por que nao na versao vegana!!','17.jpg',0,4)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
                "VALUES('X Vegan Stack','25.99','O dobro de carne vegana, a gosto do cliente','03.jpg',0,4)");

            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
               "VALUES('Coca-Cola lata 450ml','4.99','Refrigerante geladinho','21.jpg',1,5)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
               "VALUES('Pepsi lata 450ml','4.99','Refrigerante geladinho','22.jpg',1,5)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
              "VALUES('Suco de Laranja','7.99','Suco natural de laranja gelado','23.jpg',1,5)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
              "VALUES('Suco de Uva','8.99','Suco natural de uva gelado','24.jpg',0,5)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome,Preco,Descricao,ImagemUrl,LancheDoDia,CategoriaId)" +
              "VALUES('Agua 400ml','3.99','Aquela água pra matar sua sede','25.jpg',1,5)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
