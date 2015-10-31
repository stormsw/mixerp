// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Core.Fakes
{
    public class PartyRepository : IPartyRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Party> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Party(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Party(), 1);
        }

        public MixERP.Net.Entities.Core.Party Get(long partyId)
        {
            return new MixERP.Net.Entities.Core.Party();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Party> Get([FromUri] long[] partyIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Party(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Party> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Party(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Party> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Party(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Party> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Party(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Party> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Party(), 1);
        }

        public IEnumerable<DisplayField> GetDisplayFields()
        {
            return Enumerable.Repeat(new DisplayField(), 1);
        }

        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public object AddOrEdit(dynamic party, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic party, long partyId)
        {
            if (partyId > 0)
            {
                return;
            }

            throw new ArgumentException("partyId is null.");
        }

        public object Add(dynamic party)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> parties)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long partyId)
        {
            if (partyId > 0)
            {
                return;
            }

            throw new ArgumentException("partyId is null.");
        }


    }
}