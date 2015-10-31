// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface ISalesByCountryViewRepository
    {
        /// <summary>
        /// Performs count on ISalesByCountryViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesByCountryViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesByCountryView" class from ISalesByCountryViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesByCountryView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesByCountryView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesByCountryViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesByCountryViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesByCountryViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesByCountryView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesByCountryView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesByCountryViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesByCountryView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesByCountryView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesByCountryViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesByCountryView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesByCountryViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesByCountryView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesByCountryView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesByCountryViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesByCountryView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesByCountryViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesByCountryView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesByCountryView> GetFiltered(long pageNumber, string filterName);


    }
}