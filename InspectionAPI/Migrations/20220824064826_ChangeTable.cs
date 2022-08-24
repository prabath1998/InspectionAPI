﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InspectionAPI.Migrations
{
    public partial class ChangeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_inspectionTypes_InspectionTypeId",
                table: "Inspections");

            migrationBuilder.AlterColumn<int>(
                name: "InspectionTypeId",
                table: "Inspections",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_inspectionTypes_InspectionTypeId",
                table: "Inspections",
                column: "InspectionTypeId",
                principalTable: "inspectionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_inspectionTypes_InspectionTypeId",
                table: "Inspections");

            migrationBuilder.AlterColumn<int>(
                name: "InspectionTypeId",
                table: "Inspections",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_inspectionTypes_InspectionTypeId",
                table: "Inspections",
                column: "InspectionTypeId",
                principalTable: "inspectionTypes",
                principalColumn: "Id");
        }
    }
}
