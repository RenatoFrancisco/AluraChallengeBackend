using AluraChallengeBackend.Core.DomainObjects;
using AluraChallengeBackend.Domain.Validations;

namespace AluraChallengeBackend.Domain.Entities
{
    public class Video : Entity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Url { get; private set; }

        public Video(string title, 
                     string description, 
                     string url)
        {
            Title = title;
            Description = description;
            Url = url;

            Validate();
        }

        public override void Validate()
        {
            var validation = new VideoValidation().Validate(this);
            if (!validation.IsValid)
            {
                var errors = string.Join(';', validation.Errors);
                throw new DomainException(errors);
            } 
        }

        public override string ToString() => $"{Title} - {Description} - {Url}";

    }
}
