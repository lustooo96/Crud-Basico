using FluentMigrator;

namespace test
{
    [Migration(20180430121800)]
    public class AddUsuarioTable : Migration
    {
        public override void Up()
        {
            Create.Table("usuario")
                .WithColumn("idusuario").AsInt64().PrimaryKey().Identity()
                .WithColumn("nome").AsString().NotNullable()
                .WithColumn("senha").AsString().NotNullable()
                .WithColumn("email").AsString().NotNullable()
                .WithColumn("data_nascimento").AsDateTime().Nullable()
                .WithColumn("data_criacao").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("usuario");
        }
    }
}