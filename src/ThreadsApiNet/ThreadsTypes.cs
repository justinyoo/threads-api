namespace ThreadsApiNet;

public class ThreadsUser
{
    public bool is_private { get; set; }
    public string profile_pic_url { get; set; }
    public string username { get; set; }
    public ThreadsHdProfilePicVersion[] hd_profile_pic_versions { get; set; }
    public bool is_verified { get; set; }
    public string biography { get; set; }
    public object biography_with_entities { get; set; }
    public int follower_count { get; set; }
    public object profile_context_facepile_users { get; set; }
    public ThreadsBioLink[] bio_links { get; set; }
    public string pk { get; set; }
    public string full_name { get; set; }
    public object id { get; set; }
}

public class ThreadsHdProfilePicVersion
{
    public int height { get; set; }
    public string url { get; set; }
    public int width { get; set; }
}

public class ThreadsBioLink
{
    public string url { get; set; }
}

public class Thread
{
    public ThreadItem[] thread_items { get; set; }
    public string thread_type { get; set; }
    public object header { get; set; }
    public string id { get; set; }
}

public class ThreadItem
{
    public Post post { get; set; }
    public string line_type { get; set; }
    public string view_replies_cta_string { get; set; }
    public ReplyFacepileUser[] reply_facepile_users { get; set; }
    public bool should_show_replies_cta { get; set; }
    public string __typename { get; set; }
}

public class QuotedPost
{
    public TextPostAppInfo text_post_app_info { get; set; }
    public ThreadsUserSummary user { get; set; }
    public string pk { get; set; }
    public object media_overlay_info { get; set; }
    public string code { get; set; }
    public Caption caption { get; set; }
    public ImageVersions2 image_versions2 { get; set; }
    public int original_width { get; set; }
    public int original_height { get; set; }
    public object[] video_versions { get; set; }
    public object carousel_media { get; set; }
    public object carousel_media_count { get; set; }
    public object has_audio { get; set; }
    public int like_count { get; set; }
    public int taken_at { get; set; }
    public string id { get; set; }
}

public class TextPostAppInfo
{
    public object link_preview_attachment { get; set; }
    public ShareInfo share_info { get; set; }
    public object reply_to_author { get; set; }
    public bool is_post_unavailable { get; set; }
    public int direct_reply_count { get; set; }
}

public class Post
{
    public ThreadsUserSummary user { get; set; }
    public ImageVersions2 image_versions2 { get; set; }
    public int original_width { get; set; }
    public int original_height { get; set; }
    public object[] video_versions { get; set; }
    public object carousel_media { get; set; }
    public object carousel_media_count { get; set; }
    public string pk { get; set; }
    public object has_audio { get; set; }
    public TextPostAppInfo text_post_app_info { get; set; }
    public Caption caption { get; set; }
    public int taken_at { get; set; }
    public int like_count { get; set; }
    public string code { get; set; }
    public object media_overlay_info { get; set; }
    public string id { get; set; }
}

public class ThreadsUserSummary
{
    public string profile_pic_url { get; set; }
    public string username { get; set; }
    public object id { get; set; }
    public bool is_verified { get; set; }
    public string pk { get; set; }
}

public class ImageVersions2
{
    public object[] candidates { get; set; } // Either Candidate[] or ThreadsHdProfilePicVersion[]
}

public class Candidate
{
    public int height { get; set; }
    public string url { get; set; }
    public int width { get; set; }
    public string __typename { get; set; }
}

public class ShareInfo
{
    public QuotedPost quoted_post { get; set; }
    public RepostedPost reposted_post { get; set; }
}

public class RepostedPost
{
    public string pk { get; set; }
    public ThreadsUserSummary user { get; set; }
    public ImageVersions2 image_versions2 { get; set; }
    public int original_width { get; set; }
    public int original_height { get; set; }
    public VideoVersion[] video_versions { get; set; }
    public object carousel_media { get; set; }
    public object carousel_media_count { get; set; }
    public bool? has_audio { get; set; }
    public TextPostAppInfo text_post_app_info { get; set; }
    public Caption caption { get; set; }
    public int like_count { get; set; }
    public int taken_at { get; set; }
    public string code { get; set; }
    public string id { get; set; }
}

public class VideoVersion
{
    public int type { get; set; }
    public string url { get; set; }
    public string __typename { get; set; }
}

public class Caption
{
    public string text { get; set; }
}

public class ReplyFacepileUser
{
    public string __typename { get; set; }
    public object id { get; set; }
    public string profile_pic_url { get; set; }
}

public class Extensions
{
    public bool is_final { get; set; }
}
