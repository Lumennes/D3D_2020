using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//[ExecuteInEditMode]
public class BlendShapeExample : MonoBehaviour
{
    public int blendShapeCount;
    public SkinnedMeshRenderer skinnedMeshRenderer;
    public Mesh skinnedMesh;
    //public float blendOne = 0f;
    //public float blendTwo = 0f;
    //public float blendSpeed = 1f;
    //public bool blendOneFinished = false;

    //public int curBlend;
    //public float weight;

    //public List<BlendShape> blendShapes = new(52);

    
    public BlendShape[] blendShapes;

    void Awake()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
    }

    void Start()
    {
        blendShapeCount = skinnedMesh.blendShapeCount;
        blendShapes = new BlendShape[blendShapeCount];//new float[blendShapeCount];
        //blendShapes = new List<BlendShape>(blendShapeCount);

        
    }

    void Update()
    {
        //if (blendShapes == null && 
        //    skinnedMeshRenderer == null && 
        //    blendShapes.Length <= 0)
        //    return;

        //for (int i = 0; i < blendShapes.Length; i++)
        //{
        //    //blendShapes[i].index = i;
        //    blendShapes[i]._name = "jkg";//skinnedMesh.GetBlendShapeName(i);
        //}

        //skinnedMeshRenderer.SetBlendShapeWeight(0, 100);

        //if (blendShapeCount == 0 && blendShapes.Count == 0)
        //    return;
        for (int i = 0; i < blendShapes.Length; i++)
        {
            try
            {
                //if (skinnedMesh.GetBlendShapeName(i) != null &&
                //    !string.IsNullOrEmpty(skinnedMesh.GetBlendShapeName(i)))
                blendShapes[i]._name = skinnedMesh.GetBlendShapeName(i).ToString();
                skinnedMeshRenderer.SetBlendShapeWeight(i, blendShapes[i]._weight);
            }
            catch
            {

            }
            
        }

        //if (blendShapeCount > 2)
        //{
        //    if (blendOne < 100f)
        //    {
        //        skinnedMeshRenderer.SetBlendShapeWeight(0, blendOne);
        //        blendOne += blendSpeed;
        //    }
        //    else
        //    {
        //        blendOneFinished = true;
        //    }

        //    if (blendOneFinished == true && blendTwo < 100f)
        //    {
        //        skinnedMeshRenderer.SetBlendShapeWeight(1, blendTwo);
        //        blendTwo += blendSpeed;
        //    }
        //}
    }

    [System.Serializable]
    public class BlendShape
    {
        //[SerializeField]
        //public int _index;
        [SerializeField]
        public string _name;
        [SerializeField]
        [Range(0, 100)]
        public float _weight;


        //[SerializeField] 
        //public float Weight
        //{
        //    get { return _weight; }
        //    set
        //    {
        //        _weight = value;
        //        Debug.Log($"_index: {_weight}");
        //        //skinnedMeshRenderer.SetBlendShapeWeight(i, value);
        //    }
        //}
    }
}