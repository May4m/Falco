﻿module SampleApp.UI

open Falco.ViewEngine

let master pageTitle content = 
    html [ _lang "en" ] [
    head [] [
        meta  [ _charset "UTF-8" ]
        meta  [ _httpEquiv "X-UA-Compatible"; _content "IE=edge,chrome=1" ]
        meta  [ _name "viewport"; _content "width=device-width,initial-scale=1" ]
        title [] [ raw pageTitle ]                                        
        link  [ _href "/style.css"; _rel "stylesheet"]
    ]
    body [] [                     
            main [] content
        ]
] 

let homeView = 
    master "Home" [
            h1 [] [ raw "Sample App" ]
        ]

let newUserView =
    master "New User" [
            form [ _method "post" ] [
                    label [] [ raw "First Name"]
                    input [ _name "first" ] 
                    label [] [ raw "Last Name"]
                    input [ _name "last" ]
                    input [ _type "submit"; _value "Save" ]
                ]
        ]