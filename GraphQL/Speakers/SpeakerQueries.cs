using System.Linq;
using HotChocolate;
using ConferencePlanner.GraphQL.Data;
using HotChocolate.Types;

namespace ConferencePlanner.GraphQL.Speakers
{
  [ExtendObjectType(Name = "Query")]
  public class SpeakerQueries
  {
    public IQueryable<Speaker> GetSpeakers([Service] ApplicationDbContext context) =>
        context.Speakers;
  }
}