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
    public class CountySalesTaxRepository : ICountySalesTaxRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CountySalesTax(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CountySalesTax(), 1);
        }

        public MixERP.Net.Entities.Core.CountySalesTax Get(int countySalesTaxId)
        {
            return new MixERP.Net.Entities.Core.CountySalesTax();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> Get([FromUri] int[] countySalesTaxIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CountySalesTax(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CountySalesTax(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CountySalesTax(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CountySalesTax(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CountySalesTax(), 1);
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

        public object AddOrEdit(dynamic countySalesTax, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic countySalesTax, int countySalesTaxId)
        {
            if (countySalesTaxId > 0)
            {
                return;
            }

            throw new ArgumentException("countySalesTaxId is null.");
        }

        public object Add(dynamic countySalesTax)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> countySalesTaxes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int countySalesTaxId)
        {
            if (countySalesTaxId > 0)
            {
                return;
            }

            throw new ArgumentException("countySalesTaxId is null.");
        }


    }
}