using FluentMigrator;

namespace CrudBasico.Infra.Migracoes
{
    [Migration(20190430121800)]
    public class AdicionarTabelaDeUsuario : Migration
    {
        public override void Up()
        {
            Create.Table("usuario")
                .WithColumn("idusuario").AsInt64().PrimaryKey().Identity()
                .WithColumn("nome").AsString(40).NotNullable()
                .WithColumn("senha").AsString(4000).NotNullable()
                .WithColumn("email").AsString(40).NotNullable()
                .WithColumn("data_nascimento").AsDateTime().Nullable()
                .WithColumn("data_criacao").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("usuario");
        }
    }
}