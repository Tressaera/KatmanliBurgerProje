using KatmanliBurger.Data.Abstracts;

namespace KatmanliBurger.Data.DomainModels
{
	public class ParameterType:BaseEntity
	{
        public string TypeName { get; set; }
        public ICollection<ParameterDetail> ParameterDetails { get; set; }
        public ParameterType()
        {
            ParameterDetails=new HashSet<ParameterDetail>();
        }
    }
}
