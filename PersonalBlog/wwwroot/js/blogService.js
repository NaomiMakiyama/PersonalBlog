define([], function () {

    const blogPostUrl = '/Home/LatestBlogPost/';

    function loadLatestBlogPosts() {
        fetch(blogPostUrl)
            .then(function (response) {
                return response.json()
            })
            .then(function (data) {
                console.log(data);
            })
            .catch(functtion(error){
                console.log('Erro ao carregar blogs:', error);
            });
    }

    return {
        loadLatestBlogPosts: loadLatestBlogPosts
    }
})