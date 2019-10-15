namespace SysEstoque.Business
{
    /// <summary>
    /// Uma classe statica que recebe uma resposta do model sobre á ultima operação solicitada!
    /// </summary>
    public static class BllNotificar
    {
        public static string Message { get; set; }
        public static bool State { get; set; }
    }
}
