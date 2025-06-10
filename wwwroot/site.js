document.addEventListener('DOMContentLoaded', () => {
    const form = document.querySelector('form');
    form.addEventListener('submit', function (e) {
        const username = document.querySelector('#username').value;
        if (/[^a-zA-Z0-9_]/.test(username)) {
            alert('Invalid characters in username!');
            e.preventDefault();
        }
    });
});
