namespace Portal.API.GraphQL.Queries
{
    public class RootQuery 
    {
        public WebUsuarioQuery WebUsuarioQuery => new();
        public OcVehiculoQuery OcVehiculoQuery => new();
    }
}
