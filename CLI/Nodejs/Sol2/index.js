const readline = require('readline')

function countCahracters(str) {
    let newStr = str.replace(/ /g, '');

    console.log(`str ---> ${newStr}`)
    

    return newStr.length
}

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question('Input string', (str) => {
    let result = countCahracters(str)
    console.log(result)
    rl.close();
})






