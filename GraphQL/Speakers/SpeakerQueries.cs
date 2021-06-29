using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using GraphQL;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GraphQL.Data;
using GraphQL.DataLoader;
using System.Threading;

namespace GraphQL.Speakers
{
  [ExtendObjectType(Name = "Query")]
  public class SpeakerQueries
  {
    [UseApplicationDbContext]
    public Task<List<Speaker>> GetSpeakers([ScopedService] ApplicationDbContext context) =>
        context.Speakers.ToListAsync();

    public Task<Speaker> GetSpeakerAsync(
      int id,
      SpeakerByIdDataLoader dataLoader,
      CancellationToken cancellationToken) =>
dataLoader.LoadAsync(id, cancellationToken);
  }
}