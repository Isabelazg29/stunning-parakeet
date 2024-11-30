using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Glamping_Addventure2.Migrations
{
    /// <inheritdoc />
    public partial class uno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Empresa",
            //    columns: table => new
            //    {
            //        IDEmpresa = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PronombrePrimero = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Telefono = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Empresa__ED09F0D5F1EE16D2", x => x.IDEmpresa);
            //    });

            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    IDInmueble = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreInmueble = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ImagenInmueble = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CantidadInmueble = table.Column<int>(type: "int", nullable: true),
                    Precio = table.Column<int>(type: "int", nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Inmueble__8FFA1C88E82C900F", x => x.IDInmueble);
                });

            migrationBuilder.CreateTable(
                name: "MetodoPago",
                columns: table => new
                {
                    IDMetodoPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MetodoPa__8D99F33886309C22", x => x.IDMetodoPago);
                });

            migrationBuilder.CreateTable(
                name: "Paquetes",
                columns: table => new
                {
                    IDPaquete = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePaquete = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FechaInicio = table.Column<DateOnly>(type: "date", nullable: true),
                    FechaFin = table.Column<DateOnly>(type: "date", nullable: true),
                    Precio = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paquetes__4C29513B2EA3D042", x => x.IDPaquete);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    IDPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePermisos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EstadoPermisos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Permisos__F11D75F302FF0A29", x => x.IDPermiso);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IDRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Roles__A681ACB6CDE3C190", x => x.IDRol);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    IDServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreServicio = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ImagenServicio = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Duracion = table.Column<TimeOnly>(type: "time", nullable: true),
                    CantidadMaximaPersonas = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Servicio__3CCE7416760CD8A0", x => x.IDServicio);
                });

            migrationBuilder.CreateTable(
                name: "TipodeHabitacion",
                columns: table => new
                {
                    IDTipodeHabitacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipodeHabitacion = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ImagenTipodeHabitacion = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TipodeHa__9BD4086C72AEB476", x => x.IDTipodeHabitacion);
                });

            migrationBuilder.CreateTable(
                name: "TokenRecuperacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaExpiracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Usado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenRecuperacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IDCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Apellido = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IDRol = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Clientes__9B8553FC77E5836A", x => x.IDCliente);
                    table.ForeignKey(
                        name: "FK_Clientes_Roles",
                        column: x => x.IDRol,
                        principalTable: "Roles",
                        principalColumn: "IDRol");
                });

            migrationBuilder.CreateTable(
                name: "RolesPermisos",
                columns: table => new
                {
                    IDRolPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDRol = table.Column<int>(type: "int", nullable: true),
                    IDPermiso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RolesPer__3F09FABFAC4CF063", x => x.IDRolPermiso);
                    table.ForeignKey(
                        name: "FK_RolesPermisos_Permisos",
                        column: x => x.IDPermiso,
                        principalTable: "Permisos",
                        principalColumn: "IDPermiso");
                    table.ForeignKey(
                        name: "FK_RolesPermisos_Roles",
                        column: x => x.IDRol,
                        principalTable: "Roles",
                        principalColumn: "IDRol");
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IDUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Contrasena = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Apellido = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TipoDocumento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NumeroDocumento = table.Column<int>(type: "int", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IDRol = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuarios__5231116905826D68", x => x.IDUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles",
                        column: x => x.IDRol,
                        principalTable: "Roles",
                        principalColumn: "IDRol");
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
                name: "Habitacion",
                columns: table => new
                {
                    IDHabitacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreHabitacion = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ImagenHabitacion = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Piso = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CantidadPersonas = table.Column<int>(type: "int", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    IDTipodeHabitacion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Habitaci__6B4757DAE0A23709", x => x.IDHabitacion);
                    table.ForeignKey(
                        name: "FK_Habitacion_TipodeHabitacion",
                        column: x => x.IDTipodeHabitacion,
                        principalTable: "TipodeHabitacion",
                        principalColumn: "IDTipodeHabitacion");
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    IDReserva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaReserva = table.Column<DateOnly>(type: "date", nullable: true),
                    FechaInicio = table.Column<DateOnly>(type: "date", nullable: true),
                    FechaFin = table.Column<DateOnly>(type: "date", nullable: true),
                    SubTotal = table.Column<int>(type: "int", nullable: true),
                    IVA = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: true),
                    IDEmpresa = table.Column<int>(type: "int", nullable: true),
                    IDCliente = table.Column<int>(type: "int", nullable: true),
                    IDUsuario = table.Column<int>(type: "int", nullable: true),
                    IDMetodoPago = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reserva__D9F2FA671CC2091A", x => x.IDReserva);
                    table.ForeignKey(
                        name: "FK_Reserva_Cliente",
                        column: x => x.IDCliente,
                        principalTable: "Clientes",
                        principalColumn: "IDCliente");
                    table.ForeignKey(
                        name: "FK_Reserva_Empresa",
                        column: x => x.IDEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "IDEmpresa");
                    table.ForeignKey(
                        name: "FK_Reserva_MetodoPago",
                        column: x => x.IDMetodoPago,
                        principalTable: "MetodoPago",
                        principalColumn: "IDMetodoPago");
                    table.ForeignKey(
                        name: "FK_Reserva_Usuario",
                        column: x => x.IDUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IDUsuario");
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

            migrationBuilder.CreateTable(
                name: "PaquetesHabitacion",
                columns: table => new
                {
                    IDPaquetesHabitacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPaquete = table.Column<int>(type: "int", nullable: true),
                    IDHabitacion = table.Column<int>(type: "int", nullable: true)
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
                name: "Abono",
                columns: table => new
                {
                    IDAbono = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDReserva = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateOnly>(type: "date", nullable: true),
                    Subtotal = table.Column<int>(type: "int", nullable: true),
                    IVA = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Abono__8647F8A9B65C89B5", x => x.IDAbono);
                    table.ForeignKey(
                        name: "FK_Abono_Reserva",
                        column: x => x.IDReserva,
                        principalTable: "Reserva",
                        principalColumn: "IDReserva");
                });

            migrationBuilder.CreateTable(
                name: "DetalleReservaHabitacion",
                columns: table => new
                {
                    IDDetalleReservaHabitacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDReserva = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: true),
                    Precio = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IDHabitacion = table.Column<int>(type: "int", nullable: true)
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
                name: "DetalleReservaPaquetes",
                columns: table => new
                {
                    IDDetalleReservaPaquetes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDReserva = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: true),
                    Precio = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IDPaquete = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DetalleR__64F9FDAEF183D840", x => x.IDDetalleReservaPaquetes);
                    table.ForeignKey(
                        name: "FK_DetalleReservaPaquetes_Paquete",
                        column: x => x.IDPaquete,
                        principalTable: "Paquetes",
                        principalColumn: "IDPaquete");
                    table.ForeignKey(
                        name: "FK_DetalleReservaPaquetes_Reserva",
                        column: x => x.IDReserva,
                        principalTable: "Reserva",
                        principalColumn: "IDReserva");
                });

            migrationBuilder.CreateTable(
                name: "DetalleReservaServicio",
                columns: table => new
                {
                    IDDetalleReservaServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDReserva = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: true),
                    Precio = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IDServicio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DetalleR__B52B22F81FEA71BF", x => x.IDDetalleReservaServicio);
                    table.ForeignKey(
                        name: "FK_DetalleReservaServicio_Reserva",
                        column: x => x.IDReserva,
                        principalTable: "Reserva",
                        principalColumn: "IDReserva");
                    table.ForeignKey(
                        name: "FK_DetalleReservaServicio_Servicio",
                        column: x => x.IDServicio,
                        principalTable: "Servicios",
                        principalColumn: "IDServicio");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abono_IDReserva",
                table: "Abono",
                column: "IDReserva");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IDRol",
                table: "Clientes",
                column: "IDRol");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleReservaHabitacion_IDHabitacion",
                table: "DetalleReservaHabitacion",
                column: "IDHabitacion");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleReservaHabitacion_IDReserva",
                table: "DetalleReservaHabitacion",
                column: "IDReserva");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleReservaPaquetes_IDPaquete",
                table: "DetalleReservaPaquetes",
                column: "IDPaquete");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleReservaPaquetes_IDReserva",
                table: "DetalleReservaPaquetes",
                column: "IDReserva");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleReservaServicio_IDReserva",
                table: "DetalleReservaServicio",
                column: "IDReserva");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleReservaServicio_IDServicio",
                table: "DetalleReservaServicio",
                column: "IDServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Habitacion_IDTipodeHabitacion",
                table: "Habitacion",
                column: "IDTipodeHabitacion");

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

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IDCliente",
                table: "Reserva",
                column: "IDCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IDEmpresa",
                table: "Reserva",
                column: "IDEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IDMetodoPago",
                table: "Reserva",
                column: "IDMetodoPago");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_IDUsuario",
                table: "Reserva",
                column: "IDUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_RolesPermisos_IDPermiso",
                table: "RolesPermisos",
                column: "IDPermiso");

            migrationBuilder.CreateIndex(
                name: "IX_RolesPermisos_IDRol",
                table: "RolesPermisos",
                column: "IDRol");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IDRol",
                table: "Usuarios",
                column: "IDRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abono");

            migrationBuilder.DropTable(
                name: "DetalleReservaHabitacion");

            migrationBuilder.DropTable(
                name: "DetalleReservaPaquetes");

            migrationBuilder.DropTable(
                name: "DetalleReservaServicio");

            migrationBuilder.DropTable(
                name: "HabitacionInmuebles");

            migrationBuilder.DropTable(
                name: "PaquetesHabitacion");

            migrationBuilder.DropTable(
                name: "PaquetesServicio");

            migrationBuilder.DropTable(
                name: "RolesPermisos");

            migrationBuilder.DropTable(
                name: "TokenRecuperacion");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Inmuebles");

            migrationBuilder.DropTable(
                name: "Habitacion");

            migrationBuilder.DropTable(
                name: "Paquetes");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "MetodoPago");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "TipodeHabitacion");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
