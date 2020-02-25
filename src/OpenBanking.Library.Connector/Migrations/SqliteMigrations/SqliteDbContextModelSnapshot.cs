﻿// <auto-generated />
using FinnovationLabs.OpenBanking.Library.Connector.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinnovationLabs.OpenBanking.Library.Connector.Migrations.SqliteMigrations
{
    [DbContext(typeof(SqliteDbContext))]
    partial class SqliteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("FinnovationLabs.OpenBanking.Library.Connector.Model.Persistent.SoftwareStatementProfile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefaultFragmentRedirectUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObSigningKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObSigningKid")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObSigningPem")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObTransportKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObTransportPem")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoftwareStatementHeaderBase64")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoftwareStatementPayloadBase64")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoftwwareStatementSignatureBase64")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SoftwareStatementProfiles");
                });

            modelBuilder.Entity("FinnovationLabs.OpenBanking.Library.Connector.Model.Persistent.SoftwareStatementProfile", b =>
                {
                    b.OwnsOne("FinnovationLabs.OpenBanking.Library.Connector.Model.Persistent.SoftwareStatementPayload", "SoftwareStatementPayload", b1 =>
                        {
                            b1.Property<string>("SoftwareStatementProfileId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("OrgId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("OrgName")
                                .HasColumnType("TEXT");

                            b1.Property<string>("SoftwareClientDescription")
                                .HasColumnType("TEXT");

                            b1.Property<string>("SoftwareClientId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("SoftwareClientName")
                                .HasColumnType("TEXT");

                            b1.Property<string>("SoftwareClientUri")
                                .HasColumnType("TEXT");

                            b1.Property<string>("SoftwareId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("SoftwareRedirectUris")
                                .HasColumnType("TEXT");

                            b1.Property<string>("SoftwareRoles")
                                .HasColumnType("TEXT");

                            b1.Property<float>("SoftwareVersion")
                                .HasColumnType("REAL");

                            b1.HasKey("SoftwareStatementProfileId");

                            b1.ToTable("SoftwareStatementProfiles");

                            b1.WithOwner()
                                .HasForeignKey("SoftwareStatementProfileId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
