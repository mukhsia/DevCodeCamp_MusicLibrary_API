using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SongsWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedSongs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Remnant 2 OST", "Rob Westwood", "Game OST", new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "You Shall Rise (feat. Merethe Soltvedt)" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Death Stranding OST", "Ludvig Forssell", "Game OST", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BB's Theme (from Death Stranding)" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 3, "Doom Eternal OST", "Mick Gordon", "Game OST", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "BFG Division 2020 (Fortress of Doom Combat Theme)" },
                    { 4, "Warhammer 40,000: Darktide OST", "Jesper Kyd", "Game OST", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Disposal Unit (Imperium Mix)" },
                    { 5, "Remnant 2 OST", "Rob Westwood", "Game OST", new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annihilation" },
                    { 6, "Remnant 2 OST", "Rob Westwood", "Game OST", new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sha'Hala: Guardian of N'Erud (Physical)" },
                    { 7, "Remnant 2 OST", "Rob Westwood", "Game OST", new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sha'Hala: Guardian of N'Erud (Spectral)" },
                    { 8, "Remnant 2 OST", "Rob Westwood", "Game OST", new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shades of Root (Cancer)" },
                    { 9, "Where the Water Tastes Like Wine OST", "Ryan Ike", "Game OST", new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vagrant Song (Deep South" },
                    { 10, "The Sinners Songbook (From: Hunt: Showdown)", "Port Sulphur Band", "Game OST", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rise Up Dead Man" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Album1", "Artist1", "Genre1", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title1" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Album", "Artist", "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Album2", "Artist2", "Genre2", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title2" });
        }
    }
}
