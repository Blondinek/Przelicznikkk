// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Przelicznikk.Database.Context;

namespace Przelicznikk.Database.Migrations
{
    [DbContext(typeof(ConverterDbContext))]
    [Migration("20220909110649_CreateDatabaseFirstMigration")]
    partial class CreateDatabaseFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Przelicznikk.Database.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Symbol")
                        .HasColumnType("TEXT");

                    b.Property<int>("UnitTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UnitTypeId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Przelicznikk.Database.Entities.UnitConverter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("ConvertValue")
                        .HasColumnType("REAL");

                    b.Property<int>("SourceUnitId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetUnitId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SourceUnitId");

                    b.HasIndex("TargetUnitId");

                    b.ToTable("UnitConverters");
                });

            modelBuilder.Entity("Przelicznikk.Database.Entities.UnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UnitTypes");
                });

            modelBuilder.Entity("Przelicznikk.Database.Entities.Unit", b =>
                {
                    b.HasOne("Przelicznikk.Database.Entities.UnitType", "unitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("unitType");
                });

            modelBuilder.Entity("Przelicznikk.Database.Entities.UnitConverter", b =>
                {
                    b.HasOne("Przelicznikk.Database.Entities.Unit", "SourceUnit")
                        .WithMany()
                        .HasForeignKey("SourceUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Przelicznikk.Database.Entities.Unit", "TargetUnit")
                        .WithMany()
                        .HasForeignKey("TargetUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SourceUnit");

                    b.Navigation("TargetUnit");
                });
#pragma warning restore 612, 618
        }
    }
}
