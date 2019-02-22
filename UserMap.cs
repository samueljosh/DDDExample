using System;

public class UserMap : IEntityTypeConfiguration<User>
{


    //Mapping: ficará as classes referente 
    //    ao mapeamento de cada entidade.Nela 
    //realiza-se algumas configurações referente a própria entidade, 
    //como, por exemplo, o nome da tabela que vai para o banco de dados,
    //    o nome das colunas e qual será a chave primária.

    public void Configure(EntityTypeBuilder<User> builder)
    {

        builder.ToTable("User");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Cpf)
            .IsRequired()
            .HasColumnName("Cpf");

        builder.Property(c => c.Email)
            .IsRequired()
            .HasColumnName("Email");

    }
}
