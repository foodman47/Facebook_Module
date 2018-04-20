#region Imports

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Facebook.Json.Categories.Albums;
using Facebook.Json.Categories.Events;
using Facebook.Json.Categories.Page;
using Facebook.Json.Categories.Photos;
using Facebook.Json.Categories.Picture;
using Facebook.Json.Categories.Posts;
using Facebook.Json.Categories.Videos;
using Facebook.Models.Output.Categories;
using Datum = Facebook.Json.Categories.Albums.Datum;

#endregion

namespace Facebook.Extensions {
    /// <summary>
    /// 
    /// </summary>
    public static class ConvertExtensions {
        #region Public Methods

        /// <summary>
        /// Converts the specified page.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public static FacebookSubscription Convert(this Page page) {
            return page == null ? null : new FacebookSubscription {
                Name = page.name,
                Id = page.id
            };
        }

        /// <summary>
        /// Converts the album.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="limit">The limit.</param>
        /// <returns></returns>
        public static FacebookAlbum[] ConvertAlbum(this AlbumsContainer container, int limit = 25) {
            return container == null ? null : container.albums.data.ConvertAlbum().Take(limit).ToArray();
        }

        /// <summary>
        /// Converts the album.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        public static IEnumerable<FacebookAlbum> ConvertAlbum(this IEnumerable<Datum> items) {
            return items.Select(i => i.ConvertAlbum());
        }

        /// <summary>
        /// Converts the album.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static FacebookAlbum ConvertAlbum(this Datum item) {
            return new FacebookAlbum {
                CreationDate = DateTime.Parse(item.created_time, CultureInfo.InvariantCulture),
                Id = item.id,
                Name = item.name
            };
        }

        /// <summary>
        /// Converts the event.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="limit">The limit.</param>
        /// <returns></returns>
        public static FacebookEvent[] ConvertEvent(this EventsContainer container, int limit = 1) {
            return container == null ? null : container.events.data.ConvertEvent().Take(limit).ToArray();
        }

        /// <summary>
        /// Converts the event.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        public static IEnumerable<FacebookEvent> ConvertEvent(this IEnumerable<Json.Categories.Events.Datum> items) {
            return items.Select(i => i.ConvertEvent());
        }

        /// <summary>
        /// Converts the event.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static FacebookEvent ConvertEvent(this Json.Categories.Events.Datum item) {
            return new FacebookEvent {
                Description = item.description,
                EndTime = DateTime.Parse(item.end_time, CultureInfo.InvariantCulture),
                StartTime = DateTime.Parse(item.start_time, CultureInfo.InvariantCulture),
                Id = item.id,
                LocationCity = item.place.location.city,
                LocationCountry = item.place.location.country,
                LocationLatitude = item.place.location.latitude,
                LocationLongitude = item.place.location.longitude,
                LocationState = item.place.location.state,
                LocationStreet = item.place.location.street,
                LocationZip = item.place.location.zip,
                Name = item.name,
                PlaceName = item.place.name,
                PlaceId = item.place.id
            };
        }

        /// <summary>
        /// Converts the photo.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="limit">The limit.</param>
        /// <returns></returns>
        public static FacebookPhoto[] ConvertPhoto(this PhotosContainer container, int limit = 25) {
            return container == null ? null : container.photos.data.ConvertPhoto().Take(limit).ToArray();
        }

        /// <summary>
        /// Converts the photo.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        public static IEnumerable<FacebookPhoto> ConvertPhoto(this IEnumerable<Json.Categories.Photos.Datum> items) {
            return items.Select(i => i.ConvertPhoto());
        }

        /// <summary>
        /// Converts the photo.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static FacebookPhoto ConvertPhoto(this Json.Categories.Photos.Datum item) {
            return new FacebookPhoto {
                CreationDate = DateTime.Parse(item.created_time, CultureInfo.InvariantCulture),
                Id = item.id,
            };
        }

        /// <summary>
        /// Converts the picture.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns></returns>
        public static FacebookPicture ConvertPicture(this PictureContainer container) {
            return container == null ? null : new FacebookPicture {
                Id = container.id,
                IsSilhouette = container.picture.data.is_silhouette,
                Url = container.picture.data.url
            };
        }

        /// <summary>
        /// Converts the post.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="limit">The limit.</param>
        /// <returns></returns>
        public static FacebookPost[] ConvertPost(this PostsContainer container, int limit = 25) {
            return container == null ? null : container.posts.data.ConvertPost().Take(limit).ToArray();
        }

        /// <summary>
        /// Converts the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        public static IEnumerable<FacebookPost> ConvertPost(this IEnumerable<Json.Categories.Posts.Datum> items) {
            return items.Select(i => i.ConvertPost());
        }

        /// <summary>
        /// Converts the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static FacebookPost ConvertPost(this Json.Categories.Posts.Datum item) {
            return new FacebookPost {
                CreationDate = DateTime.Parse(item.created_time, CultureInfo.InvariantCulture),
                Id = item.id,
                Message = item.message,
                Story = item.story
            };
        }

        /// <summary>
        /// Converts the video.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="limit">The limit.</param>
        /// <returns></returns>
        public static FacebookVideo[] ConvertVideo(this VideosContainer container, int limit = 25) {
            return container == null ? null : container.videos.data.ConvertVideo().Take(limit).ToArray();
        }

        /// <summary>
        /// Converts the video.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        public static IEnumerable<FacebookVideo> ConvertVideo(this IEnumerable<Json.Categories.Videos.Datum> items) {
            return items.Select(i => i.ConvertVideo());
        }

        /// <summary>
        /// Converts the video.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static FacebookVideo ConvertVideo(this Json.Categories.Videos.Datum item) {
            return new FacebookVideo {
                UpdateDate = DateTime.Parse(item.updated_time, CultureInfo.InvariantCulture),
                Id = item.id,
                Description = item.description,
            };
        }

        #endregion
    }
}