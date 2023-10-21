namespace Ecommerce.CommonClass
{
    public class Multimedia
    {
        public Multimedia(string multimediaId, string mimeType, string url, string version)
        {
            MultimediaId = multimediaId;
            MimeType = mimeType;
            Url = url;
            Version = version;
        }

        /// <summary>
        /// Id de multimedia
        /// </summary>
        public string MultimediaId { get; set; }

        /// <summary>
        /// Mimetype, puede ser un .png, .jpg, etc
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Url de la media
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Version de la imagen
        /// </summary>
        public string Version { get; set; }
    }
}


