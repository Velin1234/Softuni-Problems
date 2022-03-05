async function attachEvents() {
    const postOptions = document.getElementById("posts");
    const loadPosts = document.getElementById('btnLoadPosts');
    const viewBtn = document.getElementById('btnViewPost');

    loadPosts.addEventListener('click',async ()=>{
        const postsUrl = `http://localhost:3030/jsonstore/blog/posts`;
        const resPosts = await fetch(postsUrl);
        const dataPosts = await resPosts.json();

        Object.entries(dataPosts).forEach(post => {
            let option = document.createElement('option');
            option.value = post[1].id;
            option.textContent = post[1].title.toUpperCase()
            postOptions.appendChild(option);
        });
    });

    viewBtn.addEventListener('click', async () => {
        const commentsUrl = `http://localhost:3030/jsonstore/blog/comments`;
        const resComments = await fetch(commentsUrl);
        const dataComments = await resComments.json();
        
        const postUrl = `http://localhost:3030/jsonstore/blog/posts/${postOptions.value}`;
        const resPost = await fetch(postUrl);
        const dataPost = await resPost.json();

        const text = document.getElementById('post-body');
        text.textContent = dataPost.body;

        const comments = document.getElementById('post-comments');
        comments.replaceChildren();

        Object.entries(dataComments).forEach(comment => {
            if (comment[1].postId === postOptions.value) {
                let liComment = document.createElement('li');
                liComment.textContent = comment[1].text;
                liComment.id = comment[1].id;
                comments.appendChild(liComment);
            }
        })

        const postTitle = document.getElementById('post-title');
        postTitle.textContent = postOptions.options[postOptions.selectedIndex].text;
    });
}

attachEvents();