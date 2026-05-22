using Firebase.Database;

namespace ApiRestReGraphik.Services
{
    public class ReGraphikService
    {
        // Logger para registrar informações e erros relacionados ao serviço ReGraphik
        private readonly ILogger<ReGraphikService> _logger;

        /// <summary>
        ///  Construtor da classe ReGraphikService que recebe as dependências necessárias, para permitir o registro de informações e erros durante a execução dos métodos do serviço.
        /// </summary>
        /// <param name="logger">Logger para registrar informações e erros</param>
        public ReGraphikService(ILogger<ReGraphikService> logger)
        {
            _logger = logger;
        }

        public async Task<List<string>> Listar()
        {
            try
            {

            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao listar os dados do ReGraphik: {ex.Message}");
                throw new Exception("Erro ao listar os dados do ReGraphik");
            }
        }

    }
}
