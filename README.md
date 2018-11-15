# quickchat
Quick chat API backend.

# Programming Language: C#
Using .Net Core framework 2.1, MVC model for quick coding. Sqlite is used as database. Entityframework Codefirst approach.

# Setup:
This project has CORS installed. In general, you can call from any ajax page / api consumer by one of followings:
GET http://localhost:5055/api/Chat - Get all Chat available
GET http://localhost:5055/api/Chat/{id:int} - Get all Chat that has Id > {id} (int)
POST http://localhost:5055/api/Chat/?username={username}&content={content} - Add new Chat with {username} and {content}. 

Well, I didn't put login on this, so no worry, just put any username in.


# Deploy:
You can deploy this on Linux, Windows, Mac, Docker or Wherever you want as it's .Net core framework.

# Term of use:
As you wish :)

# Contribute:
Any contribution is welcome. Just drop me few line, I'll check & merge when possible.

# Donation:
If you're happy, you can always make me happier by contribute above or by some beers at: http://paypal.me/evilcoder13
