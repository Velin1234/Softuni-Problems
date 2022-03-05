async function solution() {
    const urlArticles = `http://localhost:3030/jsonstore/advanced/articles/list`;
    const resArticles = await fetch(urlArticles);
    const dataArticles = await resArticles.json();

    const mainSection = document.getElementById('main');

    Object.entries(dataArticles).forEach(async (element) => {
        const urlArticleInfo = `http://localhost:3030/jsonstore/advanced/articles/details/${element[1]._id}`
        const resArticlesInfo = await fetch(urlArticleInfo);
        const dataArticlesInfo = await resArticlesInfo.json();

        let accordion = document.createElement('div');
        accordion.classList.add('accordion');

        let head = document.createElement('div');
        head.classList.add('head');

        let spanTitle = document.createElement('span');
        spanTitle.textContent = element[1].title;
        head.appendChild(spanTitle);

        let moreBtn = document.createElement('button');
        moreBtn.textContent = 'More';
        moreBtn.classList.add('button');
        moreBtn.id = element[1]._id;
        moreBtn.addEventListener('click', () => {
            if (moreBtn.textContent === 'Less') {
                moreBtn.textContent = "More";
                extra.style.display = '';
            } else {
                moreBtn.textContent = 'Less'
                extra.style.display = 'block';
            }
        });
        head.appendChild(moreBtn);
        accordion.appendChild(head);

        let extra = document.createElement('div');
        extra.classList.add('extra');

        let extraParagraph = document.createElement('p');
        extraParagraph.textContent = dataArticlesInfo.content;
        extra.appendChild(extraParagraph);

        accordion.appendChild(extra);

        mainSection.appendChild(accordion);
    });
}
solution();