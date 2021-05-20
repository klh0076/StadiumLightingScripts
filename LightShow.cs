using System;

public class LightShow
{

	/* FEILDS *********************/
	public byte[,] s1Values;
	public byte[,] s2Values;
	public byte[,] s3Values;
	public byte[,] s4Values;
	public byte[,] s6Values;
	public byte[,] s7Values;
	public byte[,] s8Values;
	public byte[,] s10Values;
	public byte[,] s11Values;
	public byte[,] s12Values;
	public byte[,] s13Values;
	public byte[,] s15Values;
	public byte[,] s16Values;
	public byte[,] s17Values;
	public byte[,] s19Values;
	public byte[,] s20Values;
	public byte[,] s21Values;
	public byte[,] s22Values;
	public byte[,] s23Values;
	public byte[,] s24Values;
	public byte[,] s25Values;
	public byte[,] s26Values;


/* %%%%%%%%%%%%%%%%%%%%%%%%%%%%
 * Constructor
 * 
 * IMPROVMENT - Add where it can be
 *   created based on number of frames
 * %%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
	public LightShow()
    {
		s1Values = new byte[10, 286];
		s4Values = new byte[10, 286];
		s10Values = new byte[10, 286];
		s13Values = new byte[10, 286];

		s2Values = new byte[10, 299];
		s3Values = new byte[10, 299];
		s7Values = new byte[10, 299];
		s11Values = new byte[10, 299];
		s12Values = new byte[10, 299];
		s16Values = new byte[10, 299];

		s6Values = new byte[10, 208];
		s8Values = new byte[10, 208];
		s15Values = new byte[10, 208];
		s17Values = new byte[10, 208];

		s19Values = new byte[10, 90];
		s22Values = new byte[10, 90];
		s23Values = new byte[10, 90];
		s26Values = new byte[10, 90];

		s20Values = new byte[10, 207];
		s21Values = new byte[10, 207];
		s24Values = new byte[10, 207];
		s25Values = new byte[10, 207];

	}

/* %%%%%%%%%%%%%%%%%%%%%%%%%%%%
 * GET VALUE 
 * 
 * 
 * %%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
	public byte getTheValue(int currentFrame, int sect, int index)
	{
		if (sect == 1) { return s1Values[currentFrame, index]; }
		else if (sect == 2) { return s2Values[currentFrame, index]; }
		else if (sect == 3) { return s3Values[currentFrame, index]; }
		else if (sect == 4) { return s4Values[currentFrame, index]; }
		else if (sect == 6) { return s6Values[currentFrame, index]; }
		else if (sect == 7) { return s7Values[currentFrame, index]; }
		else if (sect == 8) { return s8Values[currentFrame, index]; }
		else if (sect == 10) { return s10Values[currentFrame, index]; }
		else if (sect == 11) { return s11Values[currentFrame, index]; }
		else if (sect == 12) { return s12Values[currentFrame, index]; }
		else if (sect == 13) { return s13Values[currentFrame, index]; }
		else if (sect == 15) { return s15Values[currentFrame, index]; }
		else if (sect == 16) { return s16Values[currentFrame, index]; }
		else if (sect == 17) { return s17Values[currentFrame, index]; }
		else if (sect == 19) { return s19Values[currentFrame, index]; }
		else if (sect == 20) { return s20Values[currentFrame, index]; }
		else if (sect == 21) { return s21Values[currentFrame, index]; }
		else if (sect == 22) { return s22Values[currentFrame, index]; }
		else if (sect == 23) { return s23Values[currentFrame, index]; }
		else if (sect == 24) { return s24Values[currentFrame, index]; }
		else if (sect == 25) { return s25Values[currentFrame, index]; }
		else if (sect == 26) { return s26Values[currentFrame, index]; }
		else { return 0; }
	}

/* %%%%%%%%%%%%%%%%%%%%%%%%%%%%
 * SET VALUE
 * 
 * 
 * %%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
	public void setValue(int currentFrame, int sect, int index, byte value)
	{
		if (sect == 1) { s1Values[currentFrame, index] = value; }
		else if (sect == 2) { s2Values[currentFrame, index] = value; }
		else if (sect == 3) { s3Values[currentFrame, index] = value; }
		else if (sect == 4) { s4Values[currentFrame, index] = value; }
		else if (sect == 6) { s6Values[currentFrame, index] = value; }
		else if (sect == 7) { s7Values[currentFrame, index] = value; }
		else if (sect == 8) { s8Values[currentFrame, index] = value; }
		else if (sect == 10) { s10Values[currentFrame, index] = value; }
		else if (sect == 11) { s11Values[currentFrame, index] = value; }
		else if (sect == 12) { s12Values[currentFrame, index] = value; }
		else if (sect == 13) { s13Values[currentFrame, index] = value; }
		else if (sect == 15) { s15Values[currentFrame, index] = value; }
		else if (sect == 16) { s16Values[currentFrame, index] = value; }
		else if (sect == 17) { s17Values[currentFrame, index] = value; }
		else if (sect == 19) { s19Values[currentFrame, index] = value; }
		else if (sect == 20) { s20Values[currentFrame, index] = value; }
		else if (sect == 21) { s21Values[currentFrame, index] = value; }
		else if (sect == 22) { s22Values[currentFrame, index] = value; }
		else if (sect == 23) { s23Values[currentFrame, index] = value; }
		else if (sect == 24) { s24Values[currentFrame, index] = value; }
		else if (sect == 25) { s25Values[currentFrame, index] = value; ; }
		else if (sect == 26) { s26Values[currentFrame, index] = value; }

	}



/* %%%%%%%%%%%%%%%%%%%%%%%%%%%%
 * SET ENTIRE SECTION 
 * 
 * - sets entire section to (b)
 *     function for each section
 *     could probably be reformated
 *     to be on function
 * %%%%%%%%%%%%%%%%%%%%%%%%%%%%%% */
	public void setS1(byte b) 
    {
		int f = S.currentFrame;

		for (int i = 0; i < 286; i++)
            {
				s1Values[f, i] = b;
            }
        
    }
	public void setS4(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 286; i++)
			{
				s4Values[f, i] = b;
			}
		
	}
	public void setS10(byte b)
	{
		int f = S.currentFrame;

		for (int i = 0; i < 286; i++)
			{
				s10Values[f, i] = b;
			}
		
	}
	public void setS13(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 286; i++)
			{
				s13Values[f, i] = b;
			}
		
	}
	public void setS2(byte b)
	{
		int f = S.currentFrame;

		for (int i = 0; i < 299; i++)
			{
				s2Values[f, i] = b;
			}
		
	}
	public void setS3(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 299; i++)
			{
				s3Values[f, i] = b;
			}
		
	}
	public void setS7(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 299; i++)
			{
				s7Values[f, i] = b;
		}
		
	}
	public void setS11(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 299; i++)
			{
				s11Values[f, i] = b;
			}
		
	}
	public void setS12(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 299; i++)
			{
				s12Values[f, i] = b;
			}
		
	}
	public void setS16(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 299; i++)
			{
				s16Values[f, i] = b;
			}
		
	}
	public void setS6(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 208; i++)
			{
				s6Values[f, i] = b;
			}
		
	}
	public void setS8(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 208; i++)
			{
				s8Values[f, i] = b;
			}
		
	}
	public void setS15(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 208; i++)
			{
				s15Values[f, i] = b;
			}
		
	}
	public void setS17(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 208; i++)
			{
				s17Values[f, i] = b;
			}
		
	}
	public void setS19(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 90; i++)
			{
				s19Values[f, i] = b;
			}
		
	}
	public void setS22(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 90; i++)
			{
				s22Values[f, i] = b;
			}
		
	}
	public void setS23(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 90; i++)
			{
				s23Values[f, i] = b;
			}
		
	}
	public void setS26(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 90; i++)
			{
				s26Values[f, i] = b;
			}
		
	}
	public void setS20(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 207; i++)
			{
				s20Values[f, i] = b;
			}
		
	}
	public void setS21(byte b)
	{
		int f = S.currentFrame;

		for (int i = 0; i < 207; i++)
			{
				s21Values[f, i] = b;
			}
		
	}
	public void setS24(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 207; i++)
			{
				s24Values[f, i] = b;
			}
		
	}
	public void setS25(byte b)
	{
		int f = S.currentFrame;
		for (int i = 0; i < 207; i++)
			{
				s25Values[f, i] = b;
			}
		
	}



	
}
