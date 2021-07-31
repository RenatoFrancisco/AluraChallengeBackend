using AluraChallengeBackend.Core.DomainObjects;

namespace AluraChallengeBackend.Domain.Entities
{
    public class Video : Entity
    {
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public string Url { get; private set; }

        public Video(string titulo, 
                     string descricao, 
                     string url)
        {
            Titulo = titulo;
            Descricao = descricao;
            Url = url;
        }

        public override string ToString() => $"{Titulo} - {Descricao} - {Url}";
    }
}
