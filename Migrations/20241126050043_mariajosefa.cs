using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Glamping_Addventure2.Migrations
{
    /// <inheritdoc />
    public partial class mariajosefa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitacion_TipodeHabitacion",
                table: "Habitacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Cliente",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Empresa",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_MetodoPago",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Usuario",
                table: "Reserva");

            migrationBuilder.DropTable(
                name: "DetalleReservaHabitacion");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "HabitacionInmuebles");

            migrationBuilder.DropTable(
                name: "PaquetesHabitacion");

            migrationBuilder.DropTable(
                name: "PaquetesServicio");

            migrationBuilder.DropTable(
                name: "Inmuebles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__TipodeHa__9BD4086C72AEB476",
                table: "TipodeHabitacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Servicio__3CCE7416760CD8A0",
                table: "Servicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Reserva__D9F2FA671CC2091A",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_IDCliente",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_IDEmpresa",
                table: "Reserva");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Paquetes__4C29513B2EA3D042",
                table: "Paquetes");

            migrationBuilder.DropPrimaryKey(
                name: "PK__MetodoPa__8D99F33886309C22",
                table: "MetodoPago");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Habitaci__6B4757DAE0A23709",
                table: "Habitacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK__DetalleR__B52B22F81FEA71BF",
                table: "DetalleReservaServicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK__DetalleR__64F9FDAEF183D840",
                table: "DetalleReservaPaquetes");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Clientes__9B8553FC77E5836A",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Abono__8647F8A9B65C89B5",
                table: "Abono");

            migrationBuilder.DropColumn(
                name: "ImagenTipodeHabitacion",
                table: "TipodeHabitacion");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "TipodeHabitacion");

            migrationBuilder.DropColumn(
                name: "ImagenServicio",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "IDCliente",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "IDEmpresa",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "FechaFin",
                table: "Paquetes");

            migrationBuilder.DropColumn(
                name: "FechaInicio",
                table: "Paquetes");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "MetodoPago");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "MetodoPago");

            migrationBuilder.DropColumn(
                name: "CantidadPersonas",
                table: "Habitacion");

            migrationBuilder.DropColumn(
                name: "Piso",
                table: "Habitacion");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Habitacion");

            migrationBuilder.DropColumn(
                name: "IDCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoDocumento",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "IDReserva",
                table: "Reserva",
                newName: "IdReserva");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Reserva",
                newName: "UsuarioIdusuario");

            migrationBuilder.RenameColumn(
                name: "IDUsuario",
                table: "Reserva",
                newName: "MetodoPago");

            migrationBuilder.RenameColumn(
                name: "IDMetodoPago",
                table: "Reserva",
                newName: "IdEstadoReserva");

            migrationBuilder.RenameColumn(
                name: "FechaFin",
                table: "Reserva",
                newName: "FechaFinalizacion");

            migrationBuilder.RenameIndex(
                name: "IX_Reserva_IDUsuario",
                table: "Reserva",
                newName: "IX_Reserva_MetodoPago");

            migrationBuilder.RenameIndex(
                name: "IX_Reserva_IDMetodoPago",
                table: "Reserva",
                newName: "IX_Reserva_IdEstadoReserva");

            migrationBuilder.RenameColumn(
                name: "IDMetodoPago",
                table: "MetodoPago",
                newName: "IdMetodoPago");

            migrationBuilder.RenameColumn(
                name: "IVA",
                table: "Abono",
                newName: "Iva");

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipodeHabitacion",
                table: "TipodeHabitacion",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipodeHabitacion",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "TipodeHabitacion",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "NombreServicio",
                table: "Servicios",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Duracion",
                table: "Servicios",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(TimeOnly),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Servicios",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CantidadMaximaPersonas",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Costo",
                table: "Servicios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Servicios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<double>(
                name: "SubTotal",
                table: "Reserva",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "IVA",
                table: "Reserva",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaReserva",
                table: "Reserva",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Descuento",
                table: "Reserva",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MontoTotal",
                table: "Reserva",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NroDocumentoCliente",
                table: "Reserva",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Precio",
                table: "Paquetes",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombrePaquete",
                table: "Paquetes",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Estado",
                table: "Paquetes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Paquetes",
                type: "varchar(max)",
                unicode: false,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IDHabitacion",
                table: "Paquetes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDServicio",
                table: "Paquetes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImagenPaquete",
                table: "Paquetes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomMetodoPago",
                table: "MetodoPago",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreHabitacion",
                table: "Habitacion",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IDTipodeHabitacion",
                table: "Habitacion",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Habitacion",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Costo",
                table: "Habitacion",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Habitacion",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Estado",
                table: "DetalleReservaServicio",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "DetalleReservaPaquetes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Estado",
                table: "Clientes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NroDocumento",
                table: "Clientes",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Abono",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__TipodeHa__9BD4086CCBE5D055",
                table: "TipodeHabitacion",
                column: "IDTipodeHabitacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Servicio__3CCE7416C9E4E757",
                table: "Servicios",
                column: "IDServicio");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Reserva__0E49C69D10FD7BE6",
                table: "Reserva",
                column: "IdReserva");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Paquetes__4C29513B101B36A9",
                table: "Paquetes",
                column: "IDPaquete");

            migrationBuilder.AddPrimaryKey(
                name: "PK__MetodoPa__6F49A9BE9A98C9A3",
                table: "MetodoPago",
                column: "IdMetodoPago");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Habitaci__6B4757DA2C597849",
                table: "Habitacion",
                column: "IDHabitacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK__DetalleR__B52B22F856C9DE00",
                table: "DetalleReservaServicio",
                column: "IDDetalleReservaServicio");

            migrationBuilder.AddPrimaryKey(
                name: "PK__DetalleR__64F9FDAE5E5AF43D",
                table: "DetalleReservaPaquetes",
                column: "IDDetalleReservaPaquetes");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Clientes__CC62C91CB7C85265",
                table: "Clientes",
                column: "NroDocumento");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Abono__8647F8A90FAF0312",
                table: "Abono",
                column: "IDAbono");

            migrationBuilder.CreateTable(
                name: "EstadosReserva",
                columns: table => new
                {
                    IdEstadoReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstadoReserva = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EstadosR__3E654CA81C24A996", x => x.IdEstadoReserva);
                });

            migrationBuilder.CreateTable(
                name: "Muebles",
                columns: table => new
                {
                    IDMueble = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMueble = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    ImagenMueble = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CantidadDisponible = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Muebles__EAC9F7C835284D5B", x => x.IDMueble);
                });

            migrationBuilder.CreateTable(
                name: "HabitacionMuebles",
                columns: table => new
                {
                    IDHabitacionMuebles = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDHabitacion = table.Column<int>(type: "int", nullable: true),
                    IDMueble = table.Column<int>(type: "int", nullable: true),
                    CantidadUsada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Habitaci__65CFCA9A17EB8B03", x => x.IDHabitacionMuebles);
                    table.ForeignKey(
                        name: "FK_HabitacionMuebles_Habitacion",
                        column: x => x.IDHabitacion,
                        principalTable: "Habitacion",
                        principalColumn: "IDHabitacion");
                    table.ForeignKey(
                        name: "FK_HabitacionMuebles_Muebles",
                        column: x => x.IDMueble,
                        principalTable: "Muebles",
                        principalColumn: "IDMueble");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_NroDocumentoCliente",
                table: "Reserva",
                column: "NroDocumentoCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_UsuarioIdusuario",
                table: "Reserva",
                column: "UsuarioIdusuario");

            migrationBuilder.CreateIndex(
                name: "IX_Paquetes_IDHabitacion",
                table: "Paquetes",
                column: "IDHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_Paquetes_IDServicio",
                table: "Paquetes",
                column: "IDServicio");

            migrationBuilder.CreateIndex(
                name: "IX_HabitacionMuebles_IDHabitacion",
                table: "HabitacionMuebles",
                column: "IDHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_HabitacionMuebles_IDMueble",
                table: "HabitacionMuebles",
                column: "IDMueble");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitacion_TipodeHabitacion",
                table: "Habitacion",
                column: "IDTipodeHabitacion",
                principalTable: "TipodeHabitacion",
                principalColumn: "IDTipodeHabitacion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Habitacione_Paquetes",
                table: "Paquetes",
                column: "IDHabitacion",
                principalTable: "Habitacion",
                principalColumn: "IDHabitacion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicio_Paquetes",
                table: "Paquetes",
                column: "IDServicio",
                principalTable: "Servicios",
                principalColumn: "IDServicio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Usuarios_UsuarioIdusuario",
                table: "Reserva",
                column: "UsuarioIdusuario",
                principalTable: "Usuarios",
                principalColumn: "IDUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK__Reserva__IdEstad__6A30C649",
                table: "Reserva",
                column: "IdEstadoReserva",
                principalTable: "EstadosReserva",
                principalColumn: "IdEstadoReserva");

            migrationBuilder.AddForeignKey(
                name: "FK__Reserva__MetodoP__6B24EA82",
                table: "Reserva",
                column: "MetodoPago",
                principalTable: "MetodoPago",
                principalColumn: "IdMetodoPago");

            migrationBuilder.AddForeignKey(
                name: "FK__Reserva__NroDocu__693CA210",
                table: "Reserva",
                column: "NroDocumentoCliente",
                principalTable: "Clientes",
                principalColumn: "NroDocumento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitacion_TipodeHabitacion",
                table: "Habitacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Habitacione_Paquetes",
                table: "Paquetes");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_Paquetes",
                table: "Paquetes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Usuarios_UsuarioIdusuario",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK__Reserva__IdEstad__6A30C649",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK__Reserva__MetodoP__6B24EA82",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK__Reserva__NroDocu__693CA210",
                table: "Reserva");

            migrationBuilder.DropTable(
                name: "EstadosReserva");

            migrationBuilder.DropTable(
                name: "HabitacionMuebles");

            migrationBuilder.DropTable(
                name: "Muebles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__TipodeHa__9BD4086CCBE5D055",
                table: "TipodeHabitacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Servicio__3CCE7416C9E4E757",
                table: "Servicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Reserva__0E49C69D10FD7BE6",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_NroDocumentoCliente",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_UsuarioIdusuario",
                table: "Reserva");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Paquetes__4C29513B101B36A9",
                table: "Paquetes");

            migrationBuilder.DropIndex(
                name: "IX_Paquetes_IDHabitacion",
                table: "Paquetes");

            migrationBuilder.DropIndex(
                name: "IX_Paquetes_IDServicio",
                table: "Paquetes");

            migrationBuilder.DropPrimaryKey(
                name: "PK__MetodoPa__6F49A9BE9A98C9A3",
                table: "MetodoPago");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Habitaci__6B4757DA2C597849",
                table: "Habitacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK__DetalleR__B52B22F856C9DE00",
                table: "DetalleReservaServicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK__DetalleR__64F9FDAE5E5AF43D",
                table: "DetalleReservaPaquetes");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Clientes__CC62C91CB7C85265",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Abono__8647F8A90FAF0312",
                table: "Abono");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "TipodeHabitacion");

            migrationBuilder.DropColumn(
                name: "Costo",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "Descuento",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "MontoTotal",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "NroDocumentoCliente",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Paquetes");

            migrationBuilder.DropColumn(
                name: "IDHabitacion",
                table: "Paquetes");

            migrationBuilder.DropColumn(
                name: "IDServicio",
                table: "Paquetes");

            migrationBuilder.DropColumn(
                name: "ImagenPaquete",
                table: "Paquetes");

            migrationBuilder.DropColumn(
                name: "NomMetodoPago",
                table: "MetodoPago");

            migrationBuilder.DropColumn(
                name: "Costo",
                table: "Habitacion");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Habitacion");

            migrationBuilder.DropColumn(
                name: "NroDocumento",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "IdReserva",
                table: "Reserva",
                newName: "IDReserva");

            migrationBuilder.RenameColumn(
                name: "UsuarioIdusuario",
                table: "Reserva",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "MetodoPago",
                table: "Reserva",
                newName: "IDUsuario");

            migrationBuilder.RenameColumn(
                name: "IdEstadoReserva",
                table: "Reserva",
                newName: "IDMetodoPago");

            migrationBuilder.RenameColumn(
                name: "FechaFinalizacion",
                table: "Reserva",
                newName: "FechaFin");

            migrationBuilder.RenameIndex(
                name: "IX_Reserva_MetodoPago",
                table: "Reserva",
                newName: "IX_Reserva_IDUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Reserva_IdEstadoReserva",
                table: "Reserva",
                newName: "IX_Reserva_IDMetodoPago");

            migrationBuilder.RenameColumn(
                name: "IdMetodoPago",
                table: "MetodoPago",
                newName: "IDMetodoPago");

            migrationBuilder.RenameColumn(
                name: "Iva",
                table: "Abono",
                newName: "IVA");

            migrationBuilder.AlterColumn<string>(
                name: "NombreTipodeHabitacion",
                table: "TipodeHabitacion",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipodeHabitacion",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImagenTipodeHabitacion",
                table: "TipodeHabitacion",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "TipodeHabitacion",
                type: "decimal(18,0)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreServicio",
                table: "Servicios",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "Duracion",
                table: "Servicios",
                type: "time",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Servicios",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "CantidadMaximaPersonas",
                table: "Servicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImagenServicio",
                table: "Servicios",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Servicios",
                type: "decimal(18,0)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubTotal",
                table: "Reserva",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IVA",
                table: "Reserva",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaReserva",
                table: "Reserva",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IDCliente",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IDEmpresa",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Precio",
                table: "Paquetes",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombrePaquete",
                table: "Paquetes",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Paquetes",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateOnly>(
                name: "FechaFin",
                table: "Paquetes",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "FechaInicio",
                table: "Paquetes",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "MetodoPago",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "MetodoPago",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreHabitacion",
                table: "Habitacion",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<int>(
                name: "IDTipodeHabitacion",
                table: "Habitacion",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Habitacion",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "CantidadPersonas",
                table: "Habitacion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Piso",
                table: "Habitacion",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Habitacion",
                type: "decimal(18,0)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "DetalleReservaServicio",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "DetalleReservaPaquetes",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Clientes",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IDCliente",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "TipoDocumento",
                table: "Clientes",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Abono",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__TipodeHa__9BD4086C72AEB476",
                table: "TipodeHabitacion",
                column: "IDTipodeHabitacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Servicio__3CCE7416760CD8A0",
                table: "Servicios",
                column: "IDServicio");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Reserva__D9F2FA671CC2091A",
                table: "Reserva",
                column: "IDReserva");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Paquetes__4C29513B2EA3D042",
                table: "Paquetes",
                column: "IDPaquete");

            migrationBuilder.AddPrimaryKey(
                name: "PK__MetodoPa__8D99F33886309C22",
                table: "MetodoPago",
                column: "IDMetodoPago");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Habitaci__6B4757DAE0A23709",
                table: "Habitacion",
                column: "IDHabitacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK__DetalleR__B52B22F81FEA71BF",
                table: "DetalleReservaServicio",
                column: "IDDetalleReservaServicio");

            migrationBuilder.AddPrimaryKey(
                name: "PK__DetalleR__64F9FDAEF183D840",
                table: "DetalleReservaPaquetes",
                column: "IDDetalleReservaPaquetes");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Clientes__9B8553FC77E5836A",
                table: "Clientes",
                column: "IDCliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Abono__8647F8A9B65C89B5",
                table: "Abono",
                column: "IDAbono");

            migrationBuilder.CreateTable(
                name: "DetalleReservaHabitacion",
                columns: table => new
                {
                    IDDetalleReservaHabitacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDHabitacion = table.Column<int>(type: "int", nullable: true),
                    IDReserva = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Precio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DetalleR__8CA3B406866AC630", x => x.IDDetalleReservaHabitacion);
                    table.ForeignKey(
                        name: "FK_DetalleReservaHabitacion_Habitacion",
                        column: x => x.IDHabitacion,
                        principalTable: "Habitacion",
                        principalColumn: "IDHabitacion");
                    table.ForeignKey(
                        name: "FK_DetalleReservaHabitacion_Reserva",
                        column: x => x.IDReserva,
                        principalTable: "Reserva",
                        principalColumn: "IDReserva");
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    IDEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PronombrePrimero = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Empresa__ED09F0D5F1EE16D2", x => x.IDEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    IDInmueble = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadInmueble = table.Column<int>(type: "int", nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ImagenInmueble = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NombreInmueble = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Precio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Inmueble__8FFA1C88E82C900F", x => x.IDInmueble);
                });

            migrationBuilder.CreateTable(
                name: "PaquetesHabitacion",
                columns: table => new
                {
                    IDPaquetesHabitacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDHabitacion = table.Column<int>(type: "int", nullable: true),
                    IDPaquete = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paquetes__2EBD7781381D14C8", x => x.IDPaquetesHabitacion);
                    table.ForeignKey(
                        name: "FK_PaquetesHabitacion_Habitacion",
                        column: x => x.IDHabitacion,
                        principalTable: "Habitacion",
                        principalColumn: "IDHabitacion");
                    table.ForeignKey(
                        name: "FK_PaquetesHabitacion_Paquetes",
                        column: x => x.IDPaquete,
                        principalTable: "Paquetes",
                        principalColumn: "IDPaquete");
                });

            migrationBuilder.CreateTable(
                name: "PaquetesServicio",
                columns: table => new
                {
                    IDPaquetesServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPaquete = table.Column<int>(type: "int", nullable: true),
                    IDServicio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paquetes__C5795B25439B50EF", x => x.IDPaquetesServicio);
                    table.ForeignKey(
                        name: "FK_PaquetesServicio_Paquetes",
                        column: x => x.IDPaquete,
                        principalTable: "Paquetes",
                        principalColumn: "IDPaquete");
                    table.ForeignKey(
                        name: "FK_PaquetesServicio_Servicio",
                        column: x => x.IDServicio,
                        principalTable: "Servicios",
                        principalColumn: "IDServicio");
                });

            migrationBuilder.CreateTable(
                name: "HabitacionInmuebles",
                columns: table => new
                {
                    IDHabitacionInmuebles = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDHabitacion = table.Column<int>(type: "int", nullable: true),
                    IDInmueble = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Habitaci__8FBCBDB4862007C1", x => x.IDHabitacionInmuebles);
                    table.ForeignKey(
                        name: "FK_HabitacionInmuebles_Habitacion",
                        column: x => x.IDHabitacion,
                        principalTable: "Habitacion",
                        principalColumn: "IDHabitacion");
                    table.ForeignKey(
                        name: "FK_HabitacionInmuebles_Inmuebles",
                        column: x => x.IDInmueble,
                        principalTable: "Inmuebles",
                        principalColumn: "IDInmueble");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IDCliente",
                table: "Reserva",
                column: "IDCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IDEmpresa",
                table: "Reserva",
                column: "IDEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleReservaHabitacion_IDHabitacion",
                table: "DetalleReservaHabitacion",
                column: "IDHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleReservaHabitacion_IDReserva",
                table: "DetalleReservaHabitacion",
                column: "IDReserva");

            migrationBuilder.CreateIndex(
                name: "IX_HabitacionInmuebles_IDHabitacion",
                table: "HabitacionInmuebles",
                column: "IDHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_HabitacionInmuebles_IDInmueble",
                table: "HabitacionInmuebles",
                column: "IDInmueble");

            migrationBuilder.CreateIndex(
                name: "IX_PaquetesHabitacion_IDHabitacion",
                table: "PaquetesHabitacion",
                column: "IDHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_PaquetesHabitacion_IDPaquete",
                table: "PaquetesHabitacion",
                column: "IDPaquete");

            migrationBuilder.CreateIndex(
                name: "IX_PaquetesServicio_IDPaquete",
                table: "PaquetesServicio",
                column: "IDPaquete");

            migrationBuilder.CreateIndex(
                name: "IX_PaquetesServicio_IDServicio",
                table: "PaquetesServicio",
                column: "IDServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitacion_TipodeHabitacion",
                table: "Habitacion",
                column: "IDTipodeHabitacion",
                principalTable: "TipodeHabitacion",
                principalColumn: "IDTipodeHabitacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Cliente",
                table: "Reserva",
                column: "IDCliente",
                principalTable: "Clientes",
                principalColumn: "IDCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Empresa",
                table: "Reserva",
                column: "IDEmpresa",
                principalTable: "Empresa",
                principalColumn: "IDEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_MetodoPago",
                table: "Reserva",
                column: "IDMetodoPago",
                principalTable: "MetodoPago",
                principalColumn: "IDMetodoPago");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Usuario",
                table: "Reserva",
                column: "IDUsuario",
                principalTable: "Usuarios",
                principalColumn: "IDUsuario");
        }
    }
}
