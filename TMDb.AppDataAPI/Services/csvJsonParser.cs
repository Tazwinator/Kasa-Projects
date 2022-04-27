using Newtonsoft.Json;
using TMDb.AppDataAPI.Models;
using TMDb.DataAccess.Entities;

// This file is not currently in use as there has been an unresolved error processing the CSV "JSON" Objects.
// When back in use change "Build Action" proeprty of this file from "None" to "C# Compiler"

namespace TMDb.AppDataAPI.Services
{
    public class csvJsonParser
    {
        /// <summary>
        /// This method is used to deserialize a JSON Object using Newtonsoft.JSON. It has the additional benefit of data validation.
        /// And can be used with large CSV files containing JSON columns.
        /// </summary>
        /// <returns>
        /// Object containing deserialized JSON of type
        /// <typeparamref name="Type"></typeparamref>
        /// </returns>
        /// <typeparam name="Type">The type to be deserialized into.</typeparam>
        /// <param name="jsonString">The JSON Object.</param>
        static public Type GetModelObject<Type>(dynamic jsonString) where Type : new()
        {
            Type OutputObject = new Type();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            if (jsonString != null && jsonString.Length > 0)
            {
                
                jsonString = jsonString.Replace("'", "\"");

                var deserializedJson = JsonConvert.DeserializeObject<dynamic>(jsonString, settings); // IEnumerable

                if (typeof(Type) == typeof(List<BelongsToCollectionModel>))
                {
                    List<BelongsToCollectionModel> bcList = new();

                    bcList.Add(  new BelongsToCollectionModel {
                        Name = deserializedJson.name,
                        PosterPath = deserializedJson.poster_path,
                        BackdropPath = deserializedJson.backdrop_path,
                        Id = deserializedJson.id
                    });

                    OutputObject = (dynamic)bcList;
                }

                if (typeof(Type) == typeof(List<GenresModel>))
                {
                    List<GenresModel> gList = new();

                    if (deserializedJson.Count > 1)
                    {
                        foreach (var item in deserializedJson)
                        {
                            gList.Add(new GenresModel
                            {
                                Name = item.name,
                                Id = item.id
                            });
                        }
                    }
                    gList.Add(new GenresModel
                    {
                        Name = deserializedJson[0].name,
                        Id = deserializedJson[0].id
                    });

                    OutputObject = (dynamic)gList;
                }

                if (typeof(Type) == typeof(List<ProductionCompaniesModel>))
                {
                    List<ProductionCompaniesModel> pComList = new();

                    if (deserializedJson.Count > 1)
                    {
                        foreach (var item in deserializedJson)
                        {
                            pComList.Add(new ProductionCompaniesModel
                            {
                                Name = item.name,
                                Id = item.id,
                                LogoPath = item.logo_path,
                                OriginCountry = item.origin_country
                            });
                        }
                    }
                    pComList.Add(new ProductionCompaniesModel
                    {
                        Name = deserializedJson[0].name,
                        Id = deserializedJson[0].id,
                        LogoPath = deserializedJson[0].logo_path,
                        OriginCountry = deserializedJson[0].origin_country
                    });

                    OutputObject = (dynamic)pComList;
                }

                if (typeof(Type) == typeof(List<ProductionCountriesModel>))
                {
                    List<ProductionCountriesModel> pComList = new();

                    if (deserializedJson.Count > 1)
                    {
                        foreach (var item in deserializedJson)
                        {
                            pComList.Add(new ProductionCountriesModel
                            {
                                Name = item.name,
                                Iso_3166_1 = item.iso_3166_1
                            });
                        }
                    }
                    pComList.Add(new ProductionCountriesModel
                    {
                        Name = deserializedJson[0].name,
                        Iso_3166_1 = deserializedJson[0].iso_3166_1
                    });

                    OutputObject = (dynamic)pComList;
                }

                if (typeof(Type) == typeof(List<SpokenLanguagesModel>))
                {
                    List<SpokenLanguagesModel> pctList = new();

                    if (deserializedJson.Count > 1)
                    {
                        foreach (var item in deserializedJson)
                        {
                            pctList.Add(new SpokenLanguagesModel
                            {
                                Name = item.name,
                                Iso_639_1 = item.iso_639_1,
                                EnglishName = item.english_name
                            });
                        }
                    }
                    pctList.Add(new SpokenLanguagesModel
                    {
                        Name = deserializedJson[0].name,
                        Iso_639_1 = deserializedJson[0].iso_639_1,
                        EnglishName = deserializedJson[0].english_name
                    });

                    OutputObject = (dynamic)pctList;
                }

                //OutputObject = JsonConvert.DeserializeObject<Type>(jsonString, settings);
                
            }
            
            

            return OutputObject;

        }

        /// <summary>
        /// This method is used to deserialize a JSON Object using Newtonsoft.JSON. It has the additional benefit of data validation.
        /// And can be used with large CSV files containing JSON columns.
        /// </summary>
        /// <returns>
        /// Object containing deserialized JSON of type
        /// <typeparamref name="Type"></typeparamref>
        /// </returns>
        /// <typeparam name="Type">The type to be deserialized into.</typeparam>
        /// <param name="jsonString">The JSON Object.</param>
        static public Type GetEntityObject<Type>(dynamic jsonString) where Type : new()
        {
            Type OutputObject = new Type();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            if (jsonString != null && jsonString.Length > 0)
            {

                jsonString = jsonString.Replace("'", "\"");

                var deserializedJson = JsonConvert.DeserializeObject<dynamic>(jsonString, settings); // IEnumerable

                if (typeof(Type) == typeof(List<BelongsToCollection>))
                {
                    List<BelongsToCollection> bcList = new();

                    bcList.Add(new BelongsToCollection
                    {
                        Name = deserializedJson.name,
                        PosterPath = deserializedJson.poster_path,
                        BackdropPath = deserializedJson.backdrop_path,
                        Id = deserializedJson.id
                    });

                    OutputObject = (dynamic)bcList;
                }

                if (typeof(Type) == typeof(List<Genres>))
                {
                    List<Genres> gList = new();

                    if (deserializedJson.Count > 1)
                    {
                        foreach (var item in deserializedJson)
                        {
                            gList.Add(new Genres
                            {
                                Name = item.name,
                                Id = item.id
                            });
                        }
                    }
                    gList.Add(new Genres
                    {
                        Name = deserializedJson[0].name,
                        Id = deserializedJson[0].id
                    });

                    OutputObject = (dynamic)gList;
                }

                if (typeof(Type) == typeof(List<ProductionCompanies>))
                {
                    List<ProductionCompanies> pComList = new();

                    if (deserializedJson.Count > 1)
                    {
                        foreach (var item in deserializedJson)
                        {
                            pComList.Add(new ProductionCompanies
                            {
                                Name = item.name,
                                Id = item.id,
                                LogoPath = item.logo_path,
                                OriginCountry = item.origin_country
                            });
                        }
                    }
                    pComList.Add(new ProductionCompanies
                    {
                        Name = deserializedJson[0].name,
                        Id = deserializedJson[0].id,
                        LogoPath = deserializedJson[0].logo_path,
                        OriginCountry = deserializedJson[0].origin_country
                    });

                    OutputObject = (dynamic)pComList;
                }

                if (typeof(Type) == typeof(List<ProductionCountries>))
                {
                    List<ProductionCountries> pComList = new();

                    if (deserializedJson.Count > 1)
                    {
                        foreach (var item in deserializedJson)
                        {
                            pComList.Add(new ProductionCountries
                            {
                                Name = item.name,
                                Iso_3166_1 = item.iso_3166_1
                            });
                        }
                    }
                    pComList.Add(new ProductionCountries
                    {
                        Name = deserializedJson[0].name,
                        Iso_3166_1 = deserializedJson[0].iso_3166_1
                    });

                    OutputObject = (dynamic)pComList;
                }

                if (typeof(Type) == typeof(List<SpokenLanguages>))
                {
                    List<SpokenLanguages> pctList = new();

                    if (deserializedJson.Count > 1)
                    {
                        foreach (var item in deserializedJson)
                        {
                            pctList.Add(new SpokenLanguages
                            {
                                Name = item.name,
                                Iso_639_1 = item.iso_639_1,
                                EnglishName = item.english_name
                            });
                        }
                    }
                    pctList.Add(new SpokenLanguages
                    {
                        Name = deserializedJson[0].name,
                        Iso_639_1 = deserializedJson[0].iso_639_1,
                        EnglishName = deserializedJson[0].english_name
                    });

                    OutputObject = (dynamic)pctList;
                }

                //OutputObject = JsonConvert.DeserializeObject<Type>(jsonString, settings);

            }



            return OutputObject;

        }

    }
}
