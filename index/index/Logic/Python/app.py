# -*- coding: utf-8 -*-
"""
Created on Tue Dec 17 08:24:08 2019

@author: augus
"""
from flask import Flask, request, abort, jsonify
import model


app = Flask(__name__)


#-----------------MODELS----------------#
@app.route('/')
def make_recommendation():
    return model.getThingsTogether()
    
#-----------------ROUTES----------------#


    
    
if __name__=='__main__':
    app.run(host='0.0.0.0', port = '8000', debug = True)
    