using System;

public class Fraction
            {
                private int _top;
                private int _bottom;

                public Fraction()
                    {
                        _top = 1;
                        _bottom = 1;
                    }

                public Fraction(int wholeNumber)
                    {
                        _top = wholeNumber;
                        _bottom = 1;
                    }

                public Fraction(int top, int bottom)
                    {
                        _top = top;
                        _bottom = bottom;
                    }

                private int GetTop()
                    {
                        return _top;
                    }

                private void SetTop(int top)
                    {
                        _top = top;
                    }
                
                private int GetBottom()
                    {
                        return _bottom;
                    }

                private void SetBottom(int bottom)
                    {
                        _bottom = bottom;
                    }


                public string GetFractionString()
                    {
                        string fractionString = $"{_top}/{_bottom}";
                        
                        
                        return fractionString;
                    }

                public double GetDecimalValue()
                    {
                        return (double)_top / (double)_bottom;
                    }

            }
