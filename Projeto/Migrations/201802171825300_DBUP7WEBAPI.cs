namespace Projeto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBUP7WEBAPI : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_CARRO",
                c => new
                    {
                        ID_CARRO = c.Int(nullable: false, identity: true),
                        MARCA = c.String(nullable: false),
                        MODELO = c.String(nullable: false),
                        IMAGEM = c.String(nullable: false),
                        ANO = c.String(nullable: false),
                        preço = c.Double(nullable: false),
                        COR = c.String(),
                        QUILOMETRAGEM = c.Single(nullable: false),
                        POTENCIA = c.String(),
                        PAIS_ORIGEM = c.String(),
                        BANCOS = c.String(),
                        AR_CONDICIONADO = c.String(),
                        VIDROS = c.String(),
                        FREIOS = c.String(),
                        TRACAO = c.String(),
                        RODAS = c.String(),
                        TIPO = c.String(),
                        STATUS_CARRO = c.String(),
                    })
                .PrimaryKey(t => t.ID_CARRO);
            
            CreateTable(
                "dbo.TB_EVENTOS",
                c => new
                    {
                        ID_EVENTOS = c.Int(nullable: false, identity: true),
                        IMAGEM = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_EVENTOS);
            
            CreateTable(
                "dbo.TB_GANHADORES",
                c => new
                    {
                        ID_GANHADORES = c.Int(nullable: false, identity: true),
                        NUMERO = c.String(nullable: false),
                        NOME = c.String(nullable: false),
                        TELEFONE = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_GANHADORES);
            
            CreateTable(
                "dbo.TB_INSTITUICAO",
                c => new
                    {
                        ID_INSTITUICAO = c.Int(nullable: false, identity: true),
                        NOME = c.String(),
                        DESCRICAO = c.String(),
                        IMAGEM = c.String(),
                    })
                .PrimaryKey(t => t.ID_INSTITUICAO);
            
            CreateTable(
                "dbo.TB_LOGIN",
                c => new
                    {
                        ID_LOGIN = c.Int(nullable: false, identity: true),
                        LOGIN = c.String(nullable: false),
                        SENHA = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_LOGIN);
            
            CreateTable(
                "dbo.TB_PARCEIROS",
                c => new
                    {
                        ID_PARCEIRO = c.Int(nullable: false, identity: true),
                        NOME = c.String(nullable: false),
                        DESCRICAO = c.String(nullable: false),
                        IMAGEM = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_PARCEIRO);
            
            CreateTable(
                "dbo.TB_RIFA",
                c => new
                    {
                        ID_RIFA = c.Int(nullable: false, identity: true),
                        IMAGEM = c.String(nullable: false),
                        DESCRICAO = c.String(nullable: false),
                        PRECO = c.Double(nullable: false),
                        NUMERO = c.String(nullable: false),
                        STATUS = c.String(),
                        ID_USUARIO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_RIFA)
                .ForeignKey("dbo.TB_USUARIO", t => t.ID_USUARIO, cascadeDelete: true)
                .Index(t => t.ID_USUARIO);
            
            CreateTable(
                "dbo.TB_USUARIO",
                c => new
                    {
                        ID_USUARIO = c.Int(nullable: false, identity: true),
                        NOME = c.String(nullable: false),
                        TELEFONE = c.String(nullable: false),
                        ESTADO = c.String(nullable: false),
                        Usuario_ID_USUARIO = c.Int(),
                    })
                .PrimaryKey(t => t.ID_USUARIO)
                .ForeignKey("dbo.TB_USUARIO", t => t.Usuario_ID_USUARIO)
                .Index(t => t.Usuario_ID_USUARIO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_RIFA", "ID_USUARIO", "dbo.TB_USUARIO");
            DropForeignKey("dbo.TB_USUARIO", "Usuario_ID_USUARIO", "dbo.TB_USUARIO");
            DropIndex("dbo.TB_USUARIO", new[] { "Usuario_ID_USUARIO" });
            DropIndex("dbo.TB_RIFA", new[] { "ID_USUARIO" });
            DropTable("dbo.TB_USUARIO");
            DropTable("dbo.TB_RIFA");
            DropTable("dbo.TB_PARCEIROS");
            DropTable("dbo.TB_LOGIN");
            DropTable("dbo.TB_INSTITUICAO");
            DropTable("dbo.TB_GANHADORES");
            DropTable("dbo.TB_EVENTOS");
            DropTable("dbo.TB_CARRO");
        }
    }
}
