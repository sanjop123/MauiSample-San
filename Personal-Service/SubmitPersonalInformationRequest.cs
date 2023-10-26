using MediatR;
using personal_data;
namespace Personal_Service
{
    public class SubmitPersonalInformationRequest : IRequest<bool>
    {
        public PersonalInfo personalInfo { get; set; }  
    }

   public class SubmitPersonInforamtionHandler : IRequestHandler<SubmitPersonalInformationRequest,bool>
    {
        public Task<bool> Handle (SubmitPersonalInformationRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult (true);
        }

    }

}