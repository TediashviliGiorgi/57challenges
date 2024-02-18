document.getElementById('myForm').addEventListener('submit', function(event){
    event.preventDefault();

    const formData = new FormData(this);
    let jsonData = {};
    formData.forEach((value, key) => {
        jsonData[key] = value;
    });

    fetch('http://localhost:5216/SayHello/api/hello', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(jsonData)
    })
    .then(response => response.json())
    .then(data => {
        document.getElementById('output').textContent = data.str;
        console.log(data.str)
    })
    .catch(error => {
        console.error('Error:', error);
    });
});
