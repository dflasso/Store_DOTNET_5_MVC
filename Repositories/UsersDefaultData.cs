using System;
using System.Collections.Generic;
using G10COMERCIALIZADORA_DOTNET.Models;
using Microsoft.EntityFrameworkCore;

namespace G10COMERCIALIZADORA_DOTNET.Repositories
{
    public class UsersDefaultData
    {

        public static void CreateDefaulUsers(ModelBuilder modelBuilder)
        {
            HomeAddress addresses = new HomeAddress(1, "San Roque", "9 de Julio", "10 de Agosto", "S99-853", "Quito");
            modelBuilder.Entity<HomeAddress>().HasData(addresses);

            List<UserApp> usersDefault = new List<UserApp>();
            DateTime now = DateTime.Now;

            usersDefault.Add(new UserApp(
                1,
                "dlasso",
                "KKPpIz3t0sFYKFa6RLvVsxF4bmvZacKJ+OglgCB1/0vTZviH0yLHvhI5rYfZ6uONeb7AXbIOqxQlbKu0jagEHqFL/JhyUipqSBqJNG6SvyXR2DzDNMEYC/7h43rHX/xDf3xUHaFUo17V2VmyUnIpnOZ+KF3xXBjO64HpqyFXXtBrqonbJz0eBzd5gnmOMZfTJE2PTnDPry47dVfZAQL01z/HalLV7a6sO29QxXJ6/ZHnP6ryFW15458ZTqv/UUzw2opaK5GATs3gfPCnvbCsJVKcPDinPAyHFAgB7c6NBXe2775cNLBIDte0/eWdJj/RnrCladeV6Bgome+PQ9W+Fw==",
                now, now,
                "Dany", "Lasso", "dannyflasso99@gmail.com",
                "0999258181", (int)TypesUsers.ADMIN, "1725038968", "", 1
            ));

            usersDefault.Add(new UserApp(
                2,
                "scrisanto",
                "KKPpIz3t0sFYKFa6RLvVsxF4bmvZacKJ+OglgCB1/0vTZviH0yLHvhI5rYfZ6uONeb7AXbIOqxQlbKu0jagEHqFL/JhyUipqSBqJNG6SvyXR2DzDNMEYC/7h43rHX/xDf3xUHaFUo17V2VmyUnIpnOZ+KF3xXBjO64HpqyFXXtBrqonbJz0eBzd5gnmOMZfTJE2PTnDPry47dVfZAQL01z/HalLV7a6sO29QxXJ6/ZHnP6ryFW15458ZTqv/UUzw2opaK5GATs3gfPCnvbCsJVKcPDinPAyHFAgB7c6NBXe2775cNLBIDte0/eWdJj/RnrCladeV6Bgome+PQ9W+Fw==",
                now, now,
                "Stalin", "Crisanto", "stalincrisanto@hotmail.com",
                "0999258182", (int)TypesUsers.CLIENTES, "1725038960", "", 1
            ));

            usersDefault.Add(new UserApp(
                3,
                "xvaca",
                "KKPpIz3t0sFYKFa6RLvVsxF4bmvZacKJ+OglgCB1/0vTZviH0yLHvhI5rYfZ6uONeb7AXbIOqxQlbKu0jagEHqFL/JhyUipqSBqJNG6SvyXR2DzDNMEYC/7h43rHX/xDf3xUHaFUo17V2VmyUnIpnOZ+KF3xXBjO64HpqyFXXtBrqonbJz0eBzd5gnmOMZfTJE2PTnDPry47dVfZAQL01z/HalLV7a6sO29QxXJ6/ZHnP6ryFW15458ZTqv/UUzw2opaK5GATs3gfPCnvbCsJVKcPDinPAyHFAgB7c6NBXe2775cNLBIDte0/eWdJj/RnrCladeV6Bgome+PQ9W+Fw==",
                now, now,
                "Xavier", "Vaca", "vxvaca1@gmail.com",
                "0999258183", (int)TypesUsers.EMPLEADOS, "1725038961", "", 1
            ));

            usersDefault.Add(new UserApp(
                4,
                "temp",
                "KKPpIz3t0sFYKFa6RLvVsxF4bmvZacKJ+OglgCB1/0vTZviH0yLHvhI5rYfZ6uONeb7AXbIOqxQlbKu0jagEHqFL/JhyUipqSBqJNG6SvyXR2DzDNMEYC/7h43rHX/xDf3xUHaFUo17V2VmyUnIpnOZ+KF3xXBjO64HpqyFXXtBrqonbJz0eBzd5gnmOMZfTJE2PTnDPry47dVfZAQL01z/HalLV7a6sO29QxXJ6/ZHnP6ryFW15458ZTqv/UUzw2opaK5GATs3gfPCnvbCsJVKcPDinPAyHFAgB7c6NBXe2775cNLBIDte0/eWdJj/RnrCladeV6Bgome+PQ9W+Fw==",
                now, now,
                "temp", "", "temp@gmail.com",
                "0999258183", (int)TypesUsers.PROVEEDORES, "1725038961", "", 1
            ));

            usersDefault.Add(new UserApp(
                5,
                "blocked",
                "KKPpIz3t0sFYKFa6RLvVsxF4bmvZacKJ+OglgCB1/0vTZviH0yLHvhI5rYfZ6uONeb7AXbIOqxQlbKu0jagEHqFL/JhyUipqSBqJNG6SvyXR2DzDNMEYC/7h43rHX/xDf3xUHaFUo17V2VmyUnIpnOZ+KF3xXBjO64HpqyFXXtBrqonbJz0eBzd5gnmOMZfTJE2PTnDPry47dVfZAQL01z/HalLV7a6sO29QxXJ6/ZHnP6ryFW15458ZTqv/UUzw2opaK5GATs3gfPCnvbCsJVKcPDinPAyHFAgB7c6NBXe2775cNLBIDte0/eWdJj/RnrCladeV6Bgome+PQ9W+Fw==",
                now, now,
                "Blocked", "", "blocked@gmail.com",
                "0999258183", (int)TypesUsers.CLIENTES, "1725038961", "", 1
            ));

            modelBuilder.Entity<UserApp>().HasData(usersDefault);

            List<States> states = new List<States>();

            states.Add(new States(1, "S001", "Activo"));
            states.Add(new States(2, "S002", "Bloqueado"));
            states.Add(new States(3, "S003", "Contraseña Temporal"));

            modelBuilder.Entity<States>().HasData(states);

            List<StatesOfUser> statesOfUsers = new List<StatesOfUser>();

            statesOfUsers.Add(new StatesOfUser(1, now, now, "", 1, 1));
            statesOfUsers.Add(new StatesOfUser(2, now, now, "", 2, 1));
            statesOfUsers.Add(new StatesOfUser(3, now, now, "", 3, 1));
            statesOfUsers.Add(new StatesOfUser(4, now, now, "", 4, 3));
            statesOfUsers.Add(new StatesOfUser(5, now, now, "", 5, 2));

            modelBuilder.Entity<StatesOfUser>().HasData(statesOfUsers);

            List<Permissions> permissions = new List<Permissions>();

            permissions.Add(new Permissions(1, null, null, "Seguridades", "Permisos",
            "Administración de Permisos y Perfiles", "xe", "Permite al usuario crear o modificar los perfiles", 0));
            permissions.Add(new Permissions(2, null, null,"Personal", "Personal",
            "Administración de Usuarios", "us", "Permite crear,  modificar o eliminar usuarios", 0));
            permissions.Add(new Permissions(3, null, null, "Comercialización", "Comercialización",
            "Creación de Comprobantes Eléctronicos", "ec", "Permite al usuario crear comprobantes electrónicos.", 0));
            permissions.Add(new Permissions(4, null, null, "Finanzas", "Finanzas",
            "Reportes del Estado Financiero", "fi", "Permite al usuario obtener los reportes financieros.", 0));
            permissions.Add(new Permissions(11, "Index", "App", "Inicio", "Inicio",
            "Inicio Tienda Virtual - Monster", "ti", null, 0));

            //Permisos admin Seguridades
            permissions.Add(new Permissions(6, "Index", "Config","Admin. Permisos", "Permisos",
            "Administración de Permisos", "xe-1", "Permite al usuario editar los permisos", 1));
            permissions.Add(new Permissions(7, "Profile","Config", "Admin. Perfiles", "Perfiles",
            "Administración de Perfiles", "xe-3", "Permite al usuario crear, editar o eliminar los perfiles.", 1));
            permissions.Add(new Permissions(8, "PermissonsOfProfile","Config", "Asignación Permisos a Perfil", "Permisos-Perfil",
            "Asignación Permisos a Perfil", "xe-2", "Permite al asignar los permisos que tendrá cada perfil", 1));
            permissions.Add(new Permissions(9, "UserProfile", "Config", "Asignación Perfil a Usuario", "Perfil-Usuario",
            "Asignación de Perfil al Usuario", "xe-4", "Permite al asignar un perfil al usuario", 1));

            //Permisos admin User
            permissions.Add(new Permissions(10,"Index", "Users","Usuarios", "Usuarios",
            "Administración de Usuarios", "us", "Permite crear,  modificar o eliminar usuarios", 2));

            //permisos Comercialización
            permissions.Add(new Permissions(12,"Index", "Ecommerce","Productos", "Productos",
            "Gestión Inventario de Productos", "ec-01", "Administración de Productos", 3));
            permissions.Add(new Permissions(13,"Invoice", "Ecommerce","Facturar", "Facturas",
            "Creación de facturas", "ec-02", "Creación de facturas",  3));

            //Finanzas
            permissions.Add(new Permissions(14,"Index", "Finance","Presupuesto", "Presupuesto",
            "Obtener reportes de Presupuesto", "fi-01", "Obtener reportes de Presupuesto", 4));
            permissions.Add(new Permissions(15,"Treasury", "Finance","Tesoreria", "Tesoreria",
            "Obtener reportes de Tesoreria", "fi-02", "Obtener reportes de Tesoreria", 4));
            permissions.Add(new Permissions(16,"Accounting", "Finance","Contabilidad", "Contabilidad",
            "Obtener reportes de Contabilidad", "fi-03", "Obtener reportes de Contabilidad", 4));

            modelBuilder.Entity<Permissions>().HasData(permissions);


            List<Profile> profiles = new List<Profile>();

            profiles.Add(new Profile(1, "Super Usuario: Acceso a todo el sistema.", "p001", true));
            profiles.Add(new Profile(2, "Vendedor: Accesso a Comercialización", "p002", true));
            profiles.Add(new Profile(4, "Financiero: Accesso a Finanzas.", "p002", true));
            profiles.Add(new Profile(3, "Invitado: Sin permisos.", "p003", true));

            modelBuilder.Entity<Profile>().HasData(profiles);

            List<PermissonsOfProfile> permissonsOfProfiles = new List<PermissonsOfProfile>();

            /*Perfil Admin*/
            //permisos padre
            permissonsOfProfiles.Add(new PermissonsOfProfile(1, now, now, 11, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(2, now, now, 1, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(3, now, now, 2, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(4, now, now, 3, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(5, now, now, 4, 1));

            //permisos hijo
            permissonsOfProfiles.Add(new PermissonsOfProfile(6, now, now, 6, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(7, now, now, 7, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(8, now, now, 8, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(9, now, now, 9, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(10, now, now, 10, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(11, now, now, 12, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(12, now, now, 13, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(13, now, now, 14, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(14, now, now, 15, 1));
            permissonsOfProfiles.Add(new PermissonsOfProfile(15, now, now, 16, 1));

            /*Perfil Invitado*/
            permissonsOfProfiles.Add(new PermissonsOfProfile(16, now, now, 11, 3));

            modelBuilder.Entity<PermissonsOfProfile>().HasData(permissonsOfProfiles);

            List<UserProfile> userProfiles = new List<UserProfile>();

            userProfiles.Add(new UserProfile(1, 1, 1, now,now, null));
            userProfiles.Add(new UserProfile(2, 2, 2, now,now, null));
            userProfiles.Add(new UserProfile(3, 3, 3, now,now, null));
            userProfiles.Add(new UserProfile(4, 4, 3, now,now, null));

            modelBuilder.Entity<UserProfile>().HasData(userProfiles);
        }
    }
}