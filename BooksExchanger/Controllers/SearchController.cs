using System.Net;
using BooksExchanger.Context;
using BooksExchanger.Controllers.Specs;
using BooksExchanger.Controllers.Specs.Offers;
using BooksExchanger.Models;
using BooksExchanger.Services.Implementations.OfferService;
using BooksExchanger.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Offer = BooksExchanger.Entities.Offer;

namespace BooksExchanger.Controllers;

/// <summary>
/// Контроллер поиска.
/// </summary>
[ApiController]
[Route("api/v1/search")]
public class SearchController : ControllerBase
{
    private IOfferService _offerService;
    private ResponseMapper _responseMapper;

    public SearchController(IOfferService offerService)
    {
        _offerService = offerService;
        _responseMapper = new();
    }

    /// <summary>
    /// Осуществляет поиск офферов по названию книги.
    /// </summary>
    /// <param name="title">Начало названия книги.</param>
    /// <returns></returns>
    /// <response code="200">Успешное выполнение.</response>
    /// <response code="400">Неверный формат запроса.</response>
    [ProducesResponseType(typeof(GetOffersResponse), (int)HttpStatusCode.OK)]
    [HttpGet("by-title/{title}")]
    public IActionResult SearchByTitle(string title)
    {
        var offers = _offerService.SearchOffersByTitle(title);
        return Ok(new GetOffersResponse{Offers = offers.ConvertAll(_responseMapper.MapOffer)});
    }
    
    /// <summary>
    /// Осуществляет поиск офферов по авторам.
    /// </summary>
    /// <param name="title">Начало имени автора.</param>
    /// <returns></returns>
    /// <response code="200">Успешное выполнение.</response>
    /// <response code="400">Неверный формат запроса.</response>
    [ProducesResponseType(typeof(GetOffersResponse), (int)HttpStatusCode.OK)]
    [HttpGet("by-author/{author}")]
    public IActionResult SearchByAuthors(string author)
    {
        var offers = _offerService.SearchOffersByAuthor(author);
        return Ok(new GetOffersResponse{Offers = offers.ConvertAll(_responseMapper.MapOffer)});
    }
}