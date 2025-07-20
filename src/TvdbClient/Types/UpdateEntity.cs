using System.Runtime.Serialization;

namespace Tvdb.Types;

/// <summary>
/// The entity to update.
/// </summary>
public enum UpdateEntity
{
    /// <summary>
    /// <see cref="Models.ArtworkBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"artwork")]
    Artwork = 0,

    /// <summary>
    /// <see cref="Models.AwardNomineeBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"award_nominees")]
    Award_nominees = 1,

    /// <summary>
    /// <see cref="Models.CompanyBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"companies")]
    Companies = 2,

    /// <summary>
    /// <see cref="Models.EpisodeBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"episodes")]
    Episodes = 3,

    /// <summary>
    /// <see cref="Models.ListBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"lists")]
    Lists = 4,

    /// <summary>
    /// <see cref="Models.PeopleBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"people")]
    People = 5,

    /// <summary>
    /// <see cref="Models.SeasonBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"seasons")]
    Seasons = 6,

    /// <summary>
    /// <see cref="Models.SeriesBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"series")]
    Series = 7,

    [EnumMember(Value = @"seriespeople")]
    Seriespeople = 8,

    [EnumMember(Value = @"artworktypes")]
    Artworktypes = 9,

    /// <summary>
    /// <see cref="Models.AwardCategoryBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"award_categories")]
    Award_categories = 10,

    /// <summary>
    /// <see cref="Models.AwardBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"awards")]
    Awards = 11,

    [EnumMember(Value = @"company_types")]
    Company_types = 12,

    [EnumMember(Value = @"content_ratings")]
    Content_ratings = 13,

    /// <summary>
    /// <see cref="Models.Country"/>
    /// </summary>
    [EnumMember(Value = @"countries")]
    Countries = 14,

    /// <summary>
    /// <see cref="Models.EntityType"/>
    /// </summary>
    [EnumMember(Value = @"entity_types")]
    Entity_types = 15,

    /// <summary>
    /// <see cref="Models.GenreBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"genres")]
    Genres = 16,

    /// <summary>
    /// <see cref="Models.Language"/>
    /// </summary>
    [EnumMember(Value = @"languages")]
    Languages = 17,

    /// <summary>
    /// <see cref="Models.MovieBaseRecord"/>
    /// </summary>
    [EnumMember(Value = @"movies")]
    Movies = 18,

    [EnumMember(Value = @"movie_genres")]
    Movie_genres = 19,

    [EnumMember(Value = @"movie_status")]
    Movie_status = 20,

    [EnumMember(Value = @"peopletypes")]
    Peopletypes = 21,

    [EnumMember(Value = @"seasontypes")]
    Seasontypes = 22,

    [EnumMember(Value = @"sourcetypes")]
    Sourcetypes = 23,

    [EnumMember(Value = @"tag_options")]
    Tag_options = 24,

    [EnumMember(Value = @"tags")]
    Tags = 25,

    [EnumMember(Value = @"translatedcharacters")]
    Translatedcharacters = 26,

    [EnumMember(Value = @"translatedcompanies")]
    Translatedcompanies = 27,

    [EnumMember(Value = @"translatedepisodes")]
    Translatedepisodes = 28,

    [EnumMember(Value = @"translatedlists")]
    Translatedlists = 29,

    [EnumMember(Value = @"translatedmovies")]
    Translatedmovies = 30,

    [EnumMember(Value = @"translatedpeople")]
    Translatedpeople = 31,

    [EnumMember(Value = @"translatedseasons")]
    Translatedseasons = 32,

    [EnumMember(Value = @"translatedserierk")]
    Translatedserierk = 33,
}
