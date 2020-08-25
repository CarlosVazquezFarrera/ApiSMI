namespace SMI.Infrastructure.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using SMI.Core.CustomEntities;
    using SMI.Core.DTOs;
    using SMI.Core.Entites;
    using SMI.Core.Interfaces;
    using SMI.Infrastructure.Data;
    using System;
    using System.Data.Common;
    using System.Threading.Tasks;

    public class EmpleadoReposotory: IEmpleadoRepository
    {
        private readonly SMIContext baseDeDatos;
        public EmpleadoReposotory(SMIContext context)
        {
            baseDeDatos = context;
        }

        public async Task<Response<Empleado>> Login(Empleado empleado)
        {
            Response<Empleado> response = new Response<Empleado>();
            try
            {
                baseDeDatos.Database.OpenConnection();
                var comand = baseDeDatos.Database.GetDbConnection().CreateCommand();

                #region Paramethers

                DbParameter emailParameter = comand.CreateParameter();
                emailParameter.ParameterName = "Email";
                emailParameter.Value = empleado.Email;
                comand.Parameters.Add(emailParameter);

                DbParameter passWordParameter = comand.CreateParameter();
                passWordParameter.ParameterName = "Password";
                passWordParameter.Value = empleado.Password;
                comand.Parameters.Add(passWordParameter);
                #endregion

                comand.CommandText = "[dbo].[AutenticarEmpleado]";
                comand.CommandType = System.Data.CommandType.StoredProcedure;

                DbDataReader resultado = await comand.ExecuteReaderAsync();
                if (resultado.HasRows)
                {
                    if (resultado.Read())
                    {
                        response.Exito = resultado.GetBoolean(0);
                        response.Mensaje = resultado.GetString(1);
                        if (response.Exito)
                        {
                            response.Data = new Empleado
                            {
                                Id = resultado.GetInt32(2),
                                Nombre = resultado.GetString(3),
                                Apellidos = resultado.GetString(4)
                            };
                        }

                    }
                }
            }
            catch (Exception e)
            {

                response.Mensaje = e.ToString();
            }
            return response;
        }
    }
}
