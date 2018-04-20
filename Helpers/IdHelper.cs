#region Imports

using Facebook.Enums;
using Facebook.Extensions;
using Facebook.Json.Fields.Category;
using Facebook.Json.Fields.Comments;
using Facebook.Json.Fields.FanCount;
using Facebook.Json.Fields.Likes;
using Facebook.Json.Fields.Link;
using Facebook.Json.Fields.Picture;
using Facebook.Json.Fields.Shares;
using Facebook.Json.Fields.Source;

#endregion

namespace Facebook.Helpers {
    public static class IdHelper {
        #region Public Methods

        /// <summary>
        /// Gets the category.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static string GetCategory(this string id) {
            return JsonHelper.GetItem<Category>(GetFieldsUrl(id, FacebookItemFields.Category)).ConvertCategory().Category;
        }

        /// <summary>
        /// Gets the fan count.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static int GetFanCount(this string id) {
            return JsonHelper.GetItem<FanCount>(GetFieldsUrl(id, FacebookItemFields.Fan_Count)).ConvertFanCount().FanCount;
        }

        /// <summary>
        /// Gets the link.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static string GetLink(this string id) {
            return JsonHelper.GetItem<Link>(GetFieldsUrl(id, FacebookItemFields.Link)).ConvertLink().Link;
        }

        /// <summary>
        /// Gets the number comments.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static int GetNumberComments(this string id) {
            return JsonHelper.GetItem<Comments>(GetSubFieldsUrl(id, FacebookItemSubFields.Comments)).ConvertComments().TotalCount;
        }

        /// <summary>
        /// Gets the number likes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static int GetNumberLikes(this string id) {
            return JsonHelper.GetItem<Likes>(GetSubFieldsUrl(id, FacebookItemSubFields.Likes)).ConvertLikes().TotalCount;
        }

        /// <summary>
        /// Gets the shares.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static int GetNumberShares(this string id) {
            return JsonHelper.GetItem<SharesContainer>(GetFieldsUrl(id, FacebookItemFields.Shares)).ConvertShares().Count;
        }

        /// <summary>
        /// Gets the picture.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static string GetPicture(this string id) {
            return JsonHelper.GetItem<Picture>(GetFieldsUrl(id, FacebookItemFields.Picture)).ConvertPicture().Picture;
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static string GetSource(this string id) {
            return JsonHelper.GetItem<Source>(GetFieldsUrl(id, FacebookItemFields.Source)).ConvertSource().Source;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Gets the fields URL.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        private static string GetFieldsUrl(string id, FacebookItemFields field) {
            return string.Format("{0}/{1}?fields={2}&access_token={3}", FacebookHelper.URL, id, field.ToString().ToLower(), FacebookHelper.GetToken());
        }

        /// <summary>
        /// Gets the sub fields URL.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        private static string GetSubFieldsUrl(string id, FacebookItemSubFields field) {
            return string.Format("{0}/{1}/{2}?summary=1&access_token={3}", FacebookHelper.URL, id, field.ToString().ToLower(), FacebookHelper.GetToken());
        }

        #endregion
    }
}