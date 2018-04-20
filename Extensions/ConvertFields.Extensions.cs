#region Imports

using Facebook.Json.Fields.Category;
using Facebook.Json.Fields.Comments;
using Facebook.Json.Fields.FanCount;
using Facebook.Json.Fields.Likes;
using Facebook.Json.Fields.Link;
using Facebook.Json.Fields.Picture;
using Facebook.Json.Fields.Shares;
using Facebook.Json.Fields.Source;
using Facebook.Models.Output.Fields;

#endregion

namespace Facebook.Extensions {
    public static class ConvertFieldsExtensions {
        #region Public Methods

        /// <summary>
        /// Converts the category.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns></returns>
        public static FacebookCategory ConvertCategory(this Category container) {
            return container == null ? null : new FacebookCategory {
                Id = container.id,
                Category = container.category
            };
        }

        /// <summary>
        /// Converts the comments.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns></returns>
        public static FacebookComments ConvertComments(this Comments container) {
            return container == null ? null : new FacebookComments {
                TotalCount = container.summary.total_count
            };
        }

        /// <summary>
        /// Converts the fan count.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns></returns>
        public static FacebookFanCount ConvertFanCount(this FanCount container) {
            return container == null ? null : new FacebookFanCount {
                FanCount = container.fan_count,
                Id = container.id
            };
        }

        /// <summary>
        /// Converts the likes.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns></returns>
        public static FacebookLikes ConvertLikes(this Likes container) {
            return container == null ? null : new FacebookLikes {
                TotalCount = container.summary.total_count,
                CanLike = container.summary.can_like,
                HasLiked = container.summary.has_liked,
            };
        }

        /// <summary>
        /// Converts the link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns></returns>
        public static FacebookLink ConvertLink(this Link link) {
            return link == null ? null : new FacebookLink {
                Link = link.link,
                Id = link.id
            };
        }

        /// <summary>
        /// Convers the picture.
        /// </summary>
        /// <param name="pic">The pic.</param>
        /// <returns></returns>
        public static FacebookPicture ConvertPicture(this Picture pic) {
            return pic == null ? null : new FacebookPicture {
                Picture = pic.picture,
                Id = pic.id
            };
        }

        /// <summary>
        /// Converts the shares.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns></returns>
        public static FacebookShares ConvertShares(this SharesContainer container) {
            return container == null ? null : (container.shares == null) ? new FacebookShares {
                Count = 0,
                Id = container.id
            } : new FacebookShares {
                Count = container.shares.count,
                Id = container.id
            };
        }

        /// <summary>
        /// Converts the link.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns></returns>
        public static FacebookSource ConvertSource(this Source src) {
            return src == null ? null : new FacebookSource {
                Source = src.source,
                Id = src.id
            };
        }

        #endregion
    }
}