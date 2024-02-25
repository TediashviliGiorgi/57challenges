#first version

# def get_string(quote, author):
#     if quote is not None or quote != '' and author is not None or author != '':
#         return f"{author} says, {quote}."

# quote = input("What is the quote?: ")
# author = input("Who said it?: ")

# print(get_string(quote, author))

#challenge

operation = ""
quotes_with_authors = []
while operation != "exit":
    operation = input("Choose operation: exit, add, or seeList: ")
    if operation == exit:
        break
    elif operation == "add":
        quote = input("What is the quote?: ")
        author = input("Who said it?: ")
        if quote is not None or quote != '' and author is not None or author != '':
            quotes_with_authors.append({author : quote})
    
        else:
            print("invalid inputs")
            continue
    elif operation == "seeList":
        print(quotes_with_authors)
   