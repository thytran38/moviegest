#Beside pandas and numpy are quite popular for machine learning
# in this system I want to use cosine_similarity and CountVectorizer
#reference source: Google and a lot of websites and tutorials

import pandas as pd
import numpy as np
from sklearn.metrics.pairwise import cosine_similarity
from sklearn.feature_extraction.text import CountVectorizer

#
#START
#Reading data from movie_dataset.csv using pandas' dataframe
df = pd.read_csv('movie_dataset.csv', error_bad_lines=False)

#Features being selected means the features on which the ML model will be based on.
#Here I want to find similar movies based on their keywords that describe them, cast actors who joined filming them,
#genres where they relate to and their directors.
features = ['keywords','genres','tagline','cast','director']

#Not every dataset is filled with 100% information so I want to use fillna method
# to replace NaN values with '' value
for feature in features:
	df[feature] = df[feature].fillna('')

#
def featureCombine(row):
	try:
		return row['keywords'] + " " + row['genres'] + " " + row['tagline'] + " " + row['cast'] + " " + row['director']
	except:
		print("Error at: ", row)

df["featureCombine"] = df.apply(featureCombine,axis=1)

#
def TitleGetter(index):
	return df[df.index == index]["title"].values[0]

def IndexGetter(title):
	return df[df.title == title]["index"].values[0]
##cm = count matrix from feature combined
cv = CountVectorizer()
cM = cv.fit_transform(df["featureCombine"])

#Using cosine similarity func to calculate
cosine_sim = cosine_similarity(cM)
#print(toarray(cosine_sim))

#print("What movie you want to get recommended for?")
#write a function for return regex result
#enteredMovie = str(input())

#movie_user_likes = input(prompt='')
#enteredMovie = str(input())


##Get index of this movie from its title
#movie_index = IndexGetter(enteredMovie)

#similarMovieList = list(enumerate(cosine_sim[movie_index]))
#print(similar_movies)

##Get a list of similar movies in descending order of similarity score
#sortedSimilarMovieList = sorted(similarMovieList,key=lambda x:x[1], reverse=True)


#This block of code means I want to get them to console screen
def printMovies(sortedSimilarMovieList):
    i=1
    for movie in sortedSimilarMovieList:
    	print(TitleGetter(movie[0]))
    	i=i+1
    	if i>8:
    		break

#But actually I want to turn them to a json list and send it to client's
#through my server
def getMoviesToTxtFile(sortedSimilarMovieList):
    j = 0
    data_list = [];
    for movie in sortedSimilarMovieList:
    	data_list.append(TitleGetter(movie[0]));
    	j = j + 1
    	if j > 8:
    		break
    
    #pickle.dump()
    with open('recommendedList3.txt', 'w+') as outputFile:
    	for row in data_list:
            outputFile.write(str(row)+'\n')
        #json.dump(data_list, jsonFile)
        

def getThingsTogether(enteredMovie):
    #print("What movie you want to get recommended for?")
    #enteredMovie = str(input())
    movie_index = IndexGetter(enteredMovie)
    sortedList = list(enumerate(cosine_sim[movie_index]))
    sortedList = sorted(sortedList,key=lambda x:x[1], reverse=True)
    #printMovies(sortedList)
    getMoviesToTxtFile(sortedList)

def main():
    while True:
        file = open("argv.txt","r")
        unfixed_str = file.read()
        cappedStr = unfixed_str.title()
        print(cappedStr)
        #print(cappedStr)
        #enteredMovie = 'Death Race'
        getThingsTogether(cappedStr)
        break
    #getThingsTogether('Inception')
    
    #enteredMovie = sys.argv[1]
    #print(sys.arvg[1])
    
    #print ('Number of arguments:', len(sys.argv), 'arguments.')
    #print ('Argument List:', str(sys.argv) )   

if __name__ == "__main__":
    main()     
    
