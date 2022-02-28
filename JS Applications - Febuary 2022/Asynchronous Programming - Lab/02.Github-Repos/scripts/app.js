function loadRepos() {
	let list = document.getElementById('repos');
	let inputBox = document.getElementById('username');
	fetch(`https://api.github.com/users/${inputBox.value}/repos`, {
		method: 'GET'
	})
		.then(respone => respone.json())
		.then(result => result.forEach(item => {
			let li = document.createElement('li');
			let a = document.createElement('a');
			a.href = item["html_url"];
			a.textContent = item["name"]
			li.appendChild(a);
			list.appendChild(li);
		}));
}