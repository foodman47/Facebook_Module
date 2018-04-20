#region Imports

using Facebook.Enums;
using Facebook.Extensions;
using Facebook.Json.Categories.Albums;
using Facebook.Json.Categories.Events;
using Facebook.Json.Categories.Page;
using Facebook.Json.Categories.Photos;
using Facebook.Json.Categories.Picture;
using Facebook.Json.Categories.Posts;
using Facebook.Json.Categories.Videos;
using Facebook.Models.Input;
using Facebook.Models.Output.Categories;

#endregion

namespace Facebook.Helpers {
    public static class FacebookHelper {
        #region Public Constants

        /// <summary>
        /// The revision
        /// </summary>
        public const int Revision = 12;

        /// <summary>
        /// The version
        /// </summary>
        public const int Version = 2;

        private static string apptoken;

        /// <summary>
        /// The URL
        /// </summary>
        public static readonly string URL = string.Format("https://graph.facebook.com/v{0}.{1}", Version, Revision);

        #endregion

        #region Private Fields

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the videos.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static FacebookAlbum[] GetAlbums(this IFacebookConfiguration config) {
            return JsonHelper.GetItem<AlbumsContainer>(GetAlbumsUrl(config)).ConvertAlbum();
        }

        /// <summary>
        /// Gets the events.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static FacebookEvent[] GetEvents(this IFacebookConfiguration config) {
            return JsonHelper.GetItem<EventsContainer>(GetEventsUrl(config)).ConvertEvent();
        }

        /// <summary>
        /// Gets the photos.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static FacebookPhoto[] GetPhotos(this IFacebookConfiguration config) {
            return JsonHelper.GetItem<PhotosContainer>(GetPhotosUrl(config)).ConvertPhoto();
        }

        /// <summary>
        /// Gets the photos URL.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static string GetPhotosUrl(IFacebookConfiguration config) {
            return string.Format("{0}/{1}?fields={2}&access_token={3}", URL, config.Subscription, FacebookItemCategory.Photos.ToString().ToLower(), config.GetToken());
        }

        /// <summary>
        /// Gets the picture.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static FacebookPicture GetPicture(this IFacebookConfiguration config) {
            return JsonHelper.GetItem<PictureContainer>(GetPictureUrl(config)).ConvertPicture();
        }

        /// <summary>
        /// Gets the picture URL.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static string GetPictureUrl(IFacebookConfiguration config) {
            return string.Format("{0}/{1}?fields={2}&access_token={3}", URL, config.Subscription, FacebookItemCategory.Picture.ToString().ToLower(), config.GetToken());
        }

        /// <summary>
        /// Gets the posts.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static FacebookPost[] GetPosts(this IFacebookConfiguration config) {
            return JsonHelper.GetItem<PostsContainer>(GetPostsUrl(config)).ConvertPost();
        }

        /// <summary>
        /// Gets the post URL.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static string GetPostsUrl(IFacebookConfiguration config) {
            return string.Format("{0}/{1}?fields={2}&access_token={3}", URL, config.Subscription, FacebookItemCategory.Posts.ToString().ToLower(), config.GetToken());
        }

        /// <summary>
        /// Gets the subscription.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static FacebookSubscription GetSubscription(this IFacebookConfiguration config) {
            return JsonHelper.GetItem<Page>(GetSubscriptionUrl(config)).Convert();
        }

        /// <summary>
        /// Gets the subscription URL.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static string GetSubscriptionUrl(IFacebookConfiguration config) {
            return string.Format("{0}/{1}?access_token={2}", URL, config.Subscription, config.GetToken());
        }

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static string GetToken(this IFacebookConfiguration config) {
            return GetToken(config.AppId, config.AppSecret);
        }

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <returns></returns>
        public static string GetToken() {
            return apptoken;
        }

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="appId">The application identifier.</param>
        /// <param name="appSecret">The application secret.</param>
        /// <returns></returns>
        public static string GetToken(string appId, string appSecret) {
            apptoken = appId + "|" + appSecret;
            return appId + "|" + appSecret;
        }

        /// <summary>
        /// Gets the videos.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public static FacebookVideo[] GetVideos(this IFacebookConfiguration config) {
            return JsonHelper.GetItem<VideosContainer>(GetVideosUrl(config)).ConvertVideo();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Gets the album URL.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        private static string GetAlbumsUrl(IFacebookConfiguration config) {
            return string.Format("{0}/{1}?fields={2}&access_token={3}", URL, config.Subscription, FacebookItemCategory.Albums.ToString().ToLower(), config.GetToken());
        }

        /// <summary>
        /// Gets the event URL.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        private static string GetEventsUrl(IFacebookConfiguration config) {
            return string.Format("{0}/{1}?fields={2}&access_token={3}", URL, config.Subscription, FacebookItemCategory.Events.ToString().ToLower(), config.GetToken());
        }

        /// <summary>
        /// Gets the album URL.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        private static string GetVideosUrl(IFacebookConfiguration config) {
            return string.Format("{0}/{1}?fields={2}&access_token={3}", URL, config.Subscription, FacebookItemCategory.Videos.ToString().ToLower(), config.GetToken());
        }

        #endregion
    }
}