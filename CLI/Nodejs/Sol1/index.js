const readline = require('readline');

function greetingWithName() {
    const rl = readline.createInterface({
        input: process.stdin,
        output: process.stdout
    });

    rl.question('What is your name? ', (name) => {
        console.log(`Hello, ${name} nice to meet you!`)
        rl.close()
    });
}

greetingWithName()