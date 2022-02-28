function loadCommits() {
    let commitsBox = document.getElementById('commits');
    let username = document.getElementById('username').value;
    let repository = document.getElementById('repo').value;
    fetch(`https://api.github.com/repos/${username}/${repository}/commits`)
        .then(respone => respone.json())
        .then(result => result.forEach(element => {
            let commit = element['commit'];
            let author = commit['author'];
            let authorName = author['name'];
            let message = commit['message'];

            let li = document.createElement('li');
            li.textContent = `${authorName}: ${message}`;
            commitsBox.appendChild(li);
        }))
        .catch(error => `Error:${error.status} (Not Found)`)
}