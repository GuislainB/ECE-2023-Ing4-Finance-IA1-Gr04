﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sudoku.CNNsolver {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("sudoku.CNNsolver.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import numpy as np
        ///import pandas as pd
        ///from model import get_model
        ///from sklearn.model_selection import train_test_split
        ///
        ///def get_data(file): 
        ///
        ///    data = pd.read_csv(file)
        ///
        ///    feat_raw = data[&apos;quizzes&apos;]
        ///    label_raw = data[&apos;solutions&apos;]
        ///
        ///    feat = []
        ///    label = []
        ///
        ///    for i in feat_raw:
        ///    
        ///        x = np.array([int(j) for j in i]).reshape((9,9,1))
        ///        feat.append(x)
        ///    
        ///    feat = np.array(feat)
        ///    feat = feat/9
        ///    feat -= .5    
        ///    
        ///    for i in label_raw:
        ///    
        ///      [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string data_preprocess {
            get {
                return ResourceManager.GetString("data_preprocess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import keras
        ///from keras.layers import Activation
        ///from keras.layers import Conv2D, BatchNormalization, Dense, Flatten, Reshape
        ///
        ///def get_model():
        ///
        ///    model = keras.models.Sequential()
        ///
        ///    model.add(Conv2D(64, kernel_size=(3,3), activation=&apos;relu&apos;, padding=&apos;same&apos;, input_shape=(9,9,1)))
        ///    model.add(BatchNormalization())
        ///    model.add(Conv2D(64, kernel_size=(3,3), activation=&apos;relu&apos;, padding=&apos;same&apos;))
        ///    model.add(BatchNormalization())
        ///    model.add(Conv2D(128, kernel_size=(1,1), activation=&apos;relu&apos;, [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string model {
            get {
                return ResourceManager.GetString("model", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import copy
        ///import keras
        ///import numpy as np
        ///from model import get_model
        ///from data_preprocess import *
        ///
        ///
        ///   
        ///Sudoku = np.asarray(solve_sudoku(sudoku))
        ///
        ///    
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///.
        /// </summary>
        internal static string SolverPythonCNN {
            get {
                return ResourceManager.GetString("SolverPythonCNN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import copy
        ///import keras
        ///import numpy as np
        ///from model import get_model
        ///from data_preprocess import *
        ///
        ///
        ///   
        ///Sudoku = np.asarray(solve_sudoku(sudoku))
        ///
        ///    
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///.
        /// </summary>
        internal static string sudoku_model {
            get {
                return ResourceManager.GetString("sudoku.model", resourceCulture);
            }
        }
    }
}
